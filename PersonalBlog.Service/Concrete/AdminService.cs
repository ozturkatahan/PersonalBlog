using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Service.Dtos.AdminDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdminService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        private readonly IMapper _mapper;
        public async Task<IDataResult<AdminDto>> Get(int id)
        {
            var admin = await _unitOfWork.Admin.GetAsync(x => x.Id == id);
            if (admin != null)
            {
                return new DataResult<AdminDto>(ResultStatus.Success, new AdminDto { Admin = admin });
            }
            return new DataResult<AdminDto>(ResultStatus.Error, "Hata. Kayıt bulunamadı.", null);
        }

        public async Task<IDataResult<AdminDto>> Update(AdminUpdateDto adminUpdateDto)
        {
            if (adminUpdateDto != null)
            {
                var admin = _mapper.Map<Admin>(adminUpdateDto);
                await _unitOfWork.Admin.UpdateAsync(admin);
                await _unitOfWork.SaveAsync();
                return new DataResult<AdminDto>(ResultStatus.Success, new AdminDto { Admin = admin });
            }
            return new DataResult<AdminDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
        }
    }
}
