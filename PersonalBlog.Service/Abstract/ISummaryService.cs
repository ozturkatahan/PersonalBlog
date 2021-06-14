using PersonalBlog.Service.Dtos.SummaryDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface ISummaryService
    {
        Task<IDataResult<SummaryDto>> GetAsync(int id);
        Task<IDataResult<SummaryDto>> UpdateAsync(SummaryUpdateDto summaryUpdateDto);
    }
}
