using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Service.Dtos.AboutMeDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class AboutMeService : IAboutMeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AboutMeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<AboutMeDto>> Get(int id = 1)
        {
            var about = await _unitOfWork.AboutMe.GetAsync(x => x.Id == id);
            if (about != null)
            {
                return new DataResult<AboutMeDto>(ResultStatus.Success, new AboutMeDto { AboutMe = about });
            }
            return new DataResult<AboutMeDto>(ResultStatus.Error, "Hata. Kayıt bulunamadı.", null);
        }

        public async Task<IDataResult<AboutMeDto>> Update(AboutMeUpdateDto aboutMeUpdateDto)
        {
            if (aboutMeUpdateDto != null)
            {
                var about = _mapper.Map<AboutMe>(aboutMeUpdateDto);
                await _unitOfWork.AboutMe.UpdateAsync(about);
                await _unitOfWork.SaveAsync();
                return new DataResult<AboutMeDto>(ResultStatus.Success, new AboutMeDto { AboutMe = about });
            }
            return new DataResult<AboutMeDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
        }
    }
}
