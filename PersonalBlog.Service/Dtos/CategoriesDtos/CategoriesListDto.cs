using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Service.Dtos.CategoriesDtos
{
    public class CategoriesListDto
    {
        public IList<Categories> MyProperty { get; set; }
    }
}
