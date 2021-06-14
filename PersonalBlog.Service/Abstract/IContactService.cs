using PersonalBlog.Service.Dtos.ContactInfoDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface IContactService
    {
        Task<IDataResult<ContactInfoDto>> Get(int id);
        Task<IDataResult<ContactInfoDto>> Update(ContactInfoUpdateDto contactInfoUpdateDto);
    }
}
