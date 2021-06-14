using PersonalBlog.Service.Dtos.SlidersDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface ISliderService
    {
        Task<IDataResult<SlidersDto>> Get(int id);
        Task<IDataResult<SlidersListDto>> GetAll();
        Task<IDataResult<SlidersListDto>> GetAllByNonDelete();
        Task<IDataResult<SlidersListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<SlidersDto>> Add(SlidersAddDto slidersAddDto);
        Task<IDataResult<SlidersDto>> Update(SlidersUpdateDto slidersUpdateDto);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
