using PersonalBlog.Service.Dtos.AdminDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface IAdminService
    {
        Task<IDataResult<AdminDto>> Get(int id);
        Task<IDataResult<AdminDto>> Update(AdminUpdateDto adminUpdateDto);
    }
}
