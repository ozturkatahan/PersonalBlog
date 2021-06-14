using PersonalBlog.Service.Dtos.AboutMeDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface IAboutMeService
    {
        Task<IDataResult<AboutMeDto>> Get(int id);
        Task<IDataResult<AboutMeDto>> Update(AboutMeUpdateDto aboutMeUpdateDto);
    }
}
