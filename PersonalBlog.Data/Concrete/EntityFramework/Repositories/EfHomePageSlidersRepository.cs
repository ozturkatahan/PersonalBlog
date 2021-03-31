using Microsoft.EntityFrameworkCore;
using PersonalBlog.Data.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Shared.Data.Concerete.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfHomePageSlidersRepository : EfEntityRepositoryBase<HomePageSliders>, IHomePageSlidersRepository
    {
        public EfHomePageSlidersRepository(DbContext context) : base(context)
        {
        }
    }
}
