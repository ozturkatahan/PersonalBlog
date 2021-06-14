using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Service.Dtos.EducationDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class EducationService : IEducationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EducationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<EducationDto>> Add(EducationAddDto educationAddDto)
        {
            if (educationAddDto != null)
            {
                var education = _mapper.Map<Education>(educationAddDto);
                await _unitOfWork.Education.AddAsync(education);
                await _unitOfWork.SaveAsync();
                return new DataResult<EducationDto>(ResultStatus.Success, new EducationDto { Education = education });
            }
            return new DataResult<EducationDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
        }

        public async Task<IResult> Delete(int id)
        {
            var education = await _unitOfWork.Education.GetAsync(x => x.Id == id);
            if (education != null)
            {
                education.IsDeleted = true;
                education.ModifiedTime = DateTime.Now;
                await _unitOfWork.Education.UpdateAsync(education);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata. Kayıt bulunamadı.");
        }

        public async Task<IDataResult<EducationDto>> Get(int id)
        {
            var education = await _unitOfWork.Education.GetAsync(x => x.Id == id);
            if (education != null)
            {
                return new DataResult<EducationDto>(ResultStatus.Success, new EducationDto { Education = education} );
            }
            return new DataResult<EducationDto>(ResultStatus.Error, "Hata. Kayıt bulunamadı.", null);
        }

        public async Task<IDataResult<EducationListDto>> GetAll()
        {
            var educations = await _unitOfWork.Education.GetAllAsync();
            if (educations.Count > 0)
            {
                return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto { Educations = educations });
            }
            return new DataResult<EducationListDto>(ResultStatus.Error, "Hata. Kayıt yok", null);
        }

        public async Task<IDataResult<EducationListDto>> GetAllByNonDelete()
        {
            var educations = await _unitOfWork.Education.GetAllAsync(x => x.IsDeleted == false);
            if (educations.Count > 0)
            {
                return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto { Educations = educations });
            }
            return new DataResult<EducationListDto>(ResultStatus.Error, "Hata. Kayıt yok", null);
        }

        public async Task<IDataResult<EducationListDto>> GetAllByNonDeleteAndActive()
        {
            var educations = await _unitOfWork.Education.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true);
            if (educations.Count > 0)
            {
                return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto { Educations = educations });
            }
            return new DataResult<EducationListDto>(ResultStatus.Error, "Hata. Kayıt yok", null );
        }

        public async Task<IResult> HardDelete(int id)
        {
            Education education = await _unitOfWork.Education.GetAsync(x => x.Id == id);
            if (education != null)
            {
                await _unitOfWork.Education.DeleteAsync(education);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata. Kayıt bulunamadı.");
        }

        public async Task<IDataResult<EducationDto>> Update(EducationUpdateDto educationUpdateDto)
        {
            if (educationUpdateDto != null)
            {
                var education = _mapper.Map<Education>(educationUpdateDto);
                await _unitOfWork.Education.UpdateAsync(education);
                await _unitOfWork.SaveAsync();
                return new DataResult<EducationDto>(ResultStatus.Success, new EducationDto { Education = education });
            }
            return new DataResult<EducationDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
        }
    }
}
