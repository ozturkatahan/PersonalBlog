using PersonalBlog.Service.Dtos.InterestsDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface IInterestsService
    {
        Task<IDataResult<InterestsDto>> Get(int id);
        Task<IDataResult<InterestsListDto>> GetAll();
        Task<IDataResult<InterestsListDto>> GetAllByNonDelete();
        Task<IDataResult<InterestsListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<InterestsDto>> Add(InterestsAddDto interestsAddDto);
        Task<IDataResult<InterestsDto>> Update(InterestsUpdateDto interestsUpdateDto);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
