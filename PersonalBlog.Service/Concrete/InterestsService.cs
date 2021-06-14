using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Service.Dtos.InterestsDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class InterestsService : IInterestsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InterestsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<InterestsDto>> Add(InterestsAddDto interestsAddDto)
        {
            if (interestsAddDto != null)
            {
                //veri tabanı işlemi için kullanacağımız nesne(sorgu)
                var interests = _mapper.Map<Interests>(interestsAddDto);
                interests.CreatedTime = DateTime.Now;
                await _unitOfWork.Interests.AddAsync(interests);
                await _unitOfWork.SaveAsync();
                return new DataResult<InterestsDto>(ResultStatus.Success, new InterestsDto { Interests = interests });

            }
            return new DataResult<InterestsDto>(ResultStatus.Error, "Hata. Kayıt edilemedi.", null);
        }

        public async Task<IResult> Delete(int id)
        {
            var interests = await _unitOfWork.Interests.GetAsync(x => x.Id == id);
            if (interests != null)
            {
                interests.IsDeleted = true;
                await _unitOfWork.Interests.UpdateAsync(interests);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Kayıt bulunamadı.");
        }

        public async Task<IDataResult<InterestsDto>> Get(int id)
        {
            var interests = await _unitOfWork.Interests.GetAsync(x => x.Id == id);
            if (interests != null)
            {
                return new DataResult<InterestsDto>(ResultStatus.Success, new InterestsDto { Interests = interests });
            }
            return new DataResult<InterestsDto>(ResultStatus.Error, "Hata. Kayıt bulunamadı", null);
        }

        public async Task<IDataResult<InterestsListDto>> GetAll()
        {
            var interests = await _unitOfWork.Interests.GetAllAsync();

            if (interests.Count > 0)
            {
                return new DataResult<InterestsListDto>(ResultStatus.Success, new InterestsListDto { Interests = interests });
            }
            return new DataResult<InterestsListDto>(ResultStatus.Error, "Hata. Kayıtlar bulunamadı.", null);
        }

        public async Task<IDataResult<InterestsListDto>> GetAllByNonDelete()
        {
            var interests = await _unitOfWork.Interests.GetAllAsync(x => x.IsDeleted == false);

            if (interests.Count > 0)
            {
                return new DataResult<InterestsListDto>(ResultStatus.Success, new InterestsListDto { Interests = interests });
            }
            return new DataResult<InterestsListDto>(ResultStatus.Error, "Hata. Kayıtlar bulunamadı.", null);
        }

        public async Task<IDataResult<InterestsListDto>> GetAllByNonDeleteAndActive()
        {
            var interests = await _unitOfWork.Interests.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true);

            if (interests.Count > 0)
            {
                return new DataResult<InterestsListDto>(ResultStatus.Success, new InterestsListDto { Interests = interests });
            }
            return new DataResult<InterestsListDto>(ResultStatus.Error, "Hata. Kayıtlar bulunamadı.", null);
        }

        public async Task<IResult> HardDelete(int id)
        {
            var interests = await _unitOfWork.Interests.GetAsync(x => x.Id == id);
            if (interests != null)
            {

                await _unitOfWork.Interests.DeleteAsync(interests);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata. Kayıt bulunamadı.");
        }

        public async Task<IDataResult<InterestsDto>> Update(InterestsUpdateDto interestsUpdateDto)
        {
            if (interestsUpdateDto != null)
            {
                var interests = _mapper.Map<Interests>(interestsUpdateDto);
                await _unitOfWork.Interests.UpdateAsync(interests);
                await _unitOfWork.SaveAsync();
                return new DataResult<InterestsDto>(ResultStatus.Success, new InterestsDto { Interests = interests });
            }

            return new DataResult<InterestsDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
            
        }
    }


}
