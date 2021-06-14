using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Service.Dtos.MessagesDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class MessagesService : IMessageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MessagesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<MessagesDto>> Add(MessagesAddDto messagesAddDto)
        {
            if (messagesAddDto != null)
            {
                var message = _mapper.Map<Messages>(messagesAddDto);
                await _unitOfWork.Messages.AddAsync(message);
                await _unitOfWork.SaveAsync();
                return new DataResult<MessagesDto>(ResultStatus.Success, new MessagesDto { Messages = message });
            }
            return new DataResult<MessagesDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
        }

        public async Task<IResult> Delete(int id)
        {
            var message = await _unitOfWork.Messages.GetAsync(x => x.Id == id);
            if (message != null)
            {
                message.IsDeleted = true;
                await _unitOfWork.Messages.UpdateAsync(message);
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata. Kayıt bulunamadı.");
        }

        public async Task<IDataResult<MessagesDto>> Get(int id)
        {
            var message = await _unitOfWork.Messages.GetAsync(x => x.Id == id);
            if (message != null)
            {
                return new DataResult<MessagesDto>(ResultStatus.Success, new MessagesDto { Messages = message });
            }
            return new DataResult<MessagesDto>(ResultStatus.Error, "Hata. Kayıt bulunamadı.", null);
        }

        public async Task<IDataResult<MessagesListDto>> GetAll()
        {
            var messages = await _unitOfWork.Messages.GetAllAsync();
            if (messages.Count > 0)
            {
                return new DataResult<MessagesListDto>(ResultStatus.Success, new MessagesListDto { Messages = messages });
            }
            return new DataResult<MessagesListDto>(ResultStatus.Error, "Hata. Kayıt yok.", null);
        }

        public async Task<IDataResult<MessagesListDto>> GetAllByNonDelete()
        {
            var messages = await _unitOfWork.Messages.GetAllAsync(x => x.IsDeleted == false);
            if (messages.Count > 0)
            {
                return new DataResult<MessagesListDto>(ResultStatus.Success, new MessagesListDto { Messages = messages });
            }
            return new DataResult<MessagesListDto>(ResultStatus.Error, "Hata. Kayıt yok.", null);
        }

        public async Task<IDataResult<MessagesListDto>> GetAllByNonDeleteAndActive()
        {
            var messages = await _unitOfWork.Messages.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true);
            if (messages.Count > 0)
            {
                return new DataResult<MessagesListDto>(ResultStatus.Success, new MessagesListDto { Messages = messages });
            }
            return new DataResult<MessagesListDto>(ResultStatus.Error, "Hata. Kayıt yok.", null);
        }

        public async Task<IResult> HardDelete(int id)
        {
            var message = await _unitOfWork.Messages.GetAsync(x => x.Id == id);
            if (message != null)
            {
                await _unitOfWork.Messages.DeleteAsync(message);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata. Kayıt bulunamadı.");
        }

        public async Task<IDataResult<MessagesDto>> Update(MessagesUpdateDto messagesUpdateDto)
        {
            if (messagesUpdateDto != null)
            {
                var message = _mapper.Map<Messages>(messagesUpdateDto); // dönüşüm
                await _unitOfWork.Messages.UpdateAsync(message); //belleğe alır  
                await _unitOfWork.SaveAsync(); //veritabanına kaydeder
                return new DataResult<MessagesDto>(ResultStatus.Success, new MessagesDto { Messages = message });
            }
            return new DataResult<MessagesDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
            
        }
    }
}
