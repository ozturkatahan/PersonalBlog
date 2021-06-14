using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Service.Dtos.ArticlesDtos
{
    public class ArticlesListDto
    {
        public IList<Articles> Articles { get; set; }
    }
}
