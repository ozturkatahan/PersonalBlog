using PersonalBlog.Service.Dtos.ArticlesDtos;
using PersonalBlog.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Service.Abstract
{
    public interface IArticlesService
    {
        Task<IDataResult<ArticlesDto>> Get(int id);
        
        Task<IDataResult<ArticlesListDto>> GetAll();
        Task<IDataResult<ArticlesListDto>> GetAllByNonDelete();
        Task<IDataResult<ArticlesListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<ArticlesDto>> Add(ArticlesAddDto articlesAddDto);
        Task<IDataResult<ArticlesDto>> Update(ArticlesUpdateDto articlesUpdateDto);
        Task<IResult> Delete(int id);
        Task<IResult> IncrementRead(int id);
        Task<IResult> HardDelete(int id);
    }
}
