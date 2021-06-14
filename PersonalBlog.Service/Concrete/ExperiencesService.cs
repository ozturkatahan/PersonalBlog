using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Service.Dtos.ExperiencesDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class ExperiencesService : IExperiencesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExperiencesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        private readonly IMapper _mapper;
        public async Task<IDataResult<ExperiencesDto>> Add(ExperiencesAddDto experiencesAddDto)
        {
            if (experiencesAddDto != null)
            {
                var experience = _mapper.Map<Experiences>(experiencesAddDto);
                await _unitOfWork.Experiences.AddAsync(experience);
                await _unitOfWork.SaveAsync();
                return new DataResult<ExperiencesDto>(ResultStatus.Success, new ExperiencesDto { Experiences = experience });
            }
            return new DataResult<ExperiencesDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
        }

        public async Task<IResult> Delete(int id)
        {
            var experinces = await _unitOfWork.Experiences.GetAsync(x=> x.Id == id);
            if (experinces != null)
            {
                experinces.IsDeleted = true;
                await _unitOfWork.Experiences.UpdateAsync(experinces);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata. Kayıt bulunamadı.");
        }

        public async Task<IDataResult<ExperiencesDto>> Get(int id)
        {
            var experience = await _unitOfWork.Experiences.GetAsync(x => x.Id == id);
            if (experience != null)
            {
                return new DataResult<ExperiencesDto>(ResultStatus.Success, new ExperiencesDto { Experiences = experience });
            }
            return new DataResult<ExperiencesDto>(ResultStatus.Error, "Hata. Kayıt bulunamadı.", null);
        }

        public async Task<IDataResult<ExperiencesListDto>> GetAll()
        {
            var experiences = await _unitOfWork.Experiences.GetAllAsync();
            if (experiences.Count > 0)
            {
                return new DataResult<ExperiencesListDto>(ResultStatus.Success, new ExperiencesListDto { Experiences = experiences });
            }
            return new DataResult<ExperiencesListDto>(ResultStatus.Error, "Hata. Kayıt yok.", null);
        }

        public async Task<IDataResult<ExperiencesListDto>> GetAllByNonDelete()
        {
            var experiences = await _unitOfWork.Experiences.GetAllAsync(x => x.IsDeleted == false);
            if (experiences.Count > 0)
            {
                return new DataResult<ExperiencesListDto>(ResultStatus.Success, new ExperiencesListDto { Experiences = experiences });
            }
            return new DataResult<ExperiencesListDto>(ResultStatus.Error, "Hata. Kayıt yok.", null);
        }

        public async Task<IDataResult<ExperiencesListDto>> GetAllByNonDeleteAndActive()
        {
            var experiences = await _unitOfWork.Experiences.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true);
            if (experiences.Count > 0)
            {
                return new DataResult<ExperiencesListDto>(ResultStatus.Success, new ExperiencesListDto { Experiences = experiences });
            }
            return new DataResult<ExperiencesListDto>(ResultStatus.Error, "Hata. Kayıt yok.", null);
        }

        public async Task<IResult> HardDelete(int id)
        {
            var experience = await _unitOfWork.Experiences.GetAsync(x => x.Id == id);
            if (experience != null)
            {
                await _unitOfWork.Experiences.DeleteAsync(experience);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata. Kayıt bulunamadı.");
        }

        public async Task<IDataResult<ExperiencesDto>> Update(ExperiencesUpdateDto experiencesUpdateDto)
        {
            if (experiencesUpdateDto != null)
            {
                var experience = _mapper.Map<Experiences>(experiencesUpdateDto);
                experience.ModifiedTime = DateTime.Now;
                await _unitOfWork.Experiences.UpdateAsync(experience);
                await _unitOfWork.SaveAsync();
                return new DataResult<ExperiencesDto>(ResultStatus.Success, new ExperiencesDto { Experiences = experience });
            }
            return new DataResult<ExperiencesDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
        }
    }
}
