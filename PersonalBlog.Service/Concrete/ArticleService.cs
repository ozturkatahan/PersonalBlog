using AutoMapper;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Service.Dtos.ArticlesDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Concrete
{
    public class ArticleService : IArticlesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        private readonly IMapper _mapper;
        public async Task<IDataResult<ArticlesDto>> Add(ArticlesAddDto articlesAddDto)
        {
            if (articlesAddDto != null)
            {
                var article = _mapper.Map<Articles>(articlesAddDto);
                await _unitOfWork.Article.AddAsync(article);
                await _unitOfWork.SaveAsync();
                return new DataResult<ArticlesDto>(ResultStatus.Success, new ArticlesDto { Articles = article });
            }
            return new DataResult<ArticlesDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
        }

        public async Task<IResult> Delete(int id)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == id);
            if (article != null)
            {
                article.IsDeleted = true;
                article.ModifiedTime = DateTime.Now;
                await _unitOfWork.Article.UpdateAsync(article);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata. Kayıt bulunamadı.");
        }

        public async Task<IDataResult<ArticlesDto>> Get(int id)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == id, x => x.Categories, x => x.Comments);
            if (article != null)
            {
                return new DataResult<ArticlesDto>(ResultStatus.Success, new ArticlesDto { Articles = article });
            }
            return new DataResult<ArticlesDto>(ResultStatus.Error, "Hata. Kayıt bulunamadı.", null);
        }

        public async Task<IDataResult<ArticlesListDto>> GetAll()
        {
            var articles = await _unitOfWork.Article.GetAllAsync(null, x => x.Categories);
            if (articles.Count > 0)
            {
                return new DataResult<ArticlesListDto>(ResultStatus.Success, new ArticlesListDto { Articles = articles });
            }
            return new DataResult<ArticlesListDto>(ResultStatus.Error, "Hata. Kayıt yok.", null);
        }

        public async Task<IDataResult<ArticlesListDto>> GetAllByNonDelete()
        {
            var articles = await _unitOfWork.Article.GetAllAsync(x => x.IsDeleted == false, x => x.Categories);
            if (articles.Count > 0)
            {
                return new DataResult<ArticlesListDto>(ResultStatus.Success, new ArticlesListDto { Articles = articles });
            }
            return new DataResult<ArticlesListDto>(ResultStatus.Error, "Hata. Kayıt yok.", null);
        }

        public async Task<IDataResult<ArticlesListDto>> GetAllByNonDeleteAndActive()
        {
            var articles = await _unitOfWork.Article.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true, x => x.Categories);
            if (articles.Count > 0)
            {
                return new DataResult<ArticlesListDto>(ResultStatus.Success, new ArticlesListDto { Articles = articles });
            }
            return new DataResult<ArticlesListDto>(ResultStatus.Error, "Hata. Kayıt yok.", null);
        }

        public async Task<IResult> HardDelete(int id)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == id);
            if (article != null)
            {
                await _unitOfWork.Article.DeleteAsync(article);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata. Kayıt bulunamadı");
        }

        public async Task<IResult> IncrementRead(int id)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == id);
            if (article != null)
            {
                article.ViewsCount += 1;
                article.ModifiedTime = DateTime.Now;
                await _unitOfWork.Article.UpdateAsync(article);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata. Kayıt bulunamadı.");
        }

        public async Task<IDataResult<ArticlesDto>> Update(ArticlesUpdateDto articlesUpdateDto)
        {
            if (articlesUpdateDto != null)
            {
                var article = _mapper.Map<Articles>(articlesUpdateDto);
                article.ModifiedTime = DateTime.Now;
                await _unitOfWork.Article.UpdateAsync(article);
                await _unitOfWork.SaveAsync();
                return new DataResult<ArticlesDto>(ResultStatus.Success, new ArticlesDto { Articles = article });
            }
            return new DataResult<ArticlesDto>(ResultStatus.Error, "Hata. Girdiğiniz bilgileri kontrol ediniz.", null);
        }
    }
}
