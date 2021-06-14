using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Service.Dtos.SiteIdentityDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class SiteIdentityService : ISiteIdentityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SiteIdentityService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        private readonly IMapper _mapper;
        public async Task<IDataResult<SiteIdentityDto>> Get(int id = 1)
        {
            var identity = await _unitOfWork.SiteIdentity.GetAsync(x => x.Id == id);
            if (identity != null)
            {
                return new DataResult<SiteIdentityDto>(ResultStatus.Success, new SiteIdentityDto { SiteIdentity = identity });
            }
            return new DataResult<SiteIdentityDto>(ResultStatus.Error, "Hata. Kayıt yok.", null);
        }

        public async Task<IDataResult<SiteIdentityDto>> Update(SiteIdentityUpdateDto siteIdentityUpdateDto)
        {
            if (siteIdentityUpdateDto != null)
            {
                var identity = _mapper.Map<SiteIdentity>(siteIdentityUpdateDto);
                await _unitOfWork.SiteIdentity.UpdateAsync(identity);
                await _unitOfWork.SaveAsync();
                return new DataResult<SiteIdentityDto>(ResultStatus.Success, new SiteIdentityDto { SiteIdentity = identity });
            }
            return new DataResult<SiteIdentityDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
        }
    }
}
