using PersonalBlog.Entities.Concrete;
using PersonalBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Data.Abstract
{
    public interface IArticleRepository : IEntityRepository<Articles>
    {
    }
}
