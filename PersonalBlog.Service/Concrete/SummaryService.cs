using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Service.Dtos.SummaryDtos;
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
    public class SummaryService : ISummaryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SummaryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<SummaryDto>> GetAsync(int id)
        {
            var summary = await _unitOfWork.Summary.GetAsync(x => x.Id == id);
            if (summary != null)
            {
                return new DataResult<SummaryDto>(ResultStatus.Success, new SummaryDto { Summary = summary });
            }
            return new DataResult<SummaryDto>(ResultStatus.Error, "Hata, Kayıt bulunamadı!", null);
        }

        public async Task<IDataResult<SummaryDto>> UpdateAsync(SummaryUpdateDto summaryUpdateDto)
        {
            if (summaryUpdateDto != null)
            {
                var summary = _mapper.Map<Summary>(summaryUpdateDto);
                await _unitOfWork.Summary.UpdateAsync(summary);
                await _unitOfWork.SaveAsync();
                return new DataResult<SummaryDto>(ResultStatus.Success, new SummaryDto { Summary = summary });
            }

            return new DataResult<SummaryDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
            
               
        }
    }
}
