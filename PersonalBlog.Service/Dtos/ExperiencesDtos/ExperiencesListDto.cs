using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Service.Dtos.ExperiencesDtos
{
    public class ExperiencesListDto
    {
        public IList<Experiences> Experiences { get; set; }
    }
}
