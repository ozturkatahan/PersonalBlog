using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Entities.Dtos.EducationDtos
{
    public class EducationListDto
    {
        public IList<Education> Educations { get; set; }
    }
}
