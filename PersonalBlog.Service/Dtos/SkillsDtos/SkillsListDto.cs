using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Service.Dtos.SkillsDtos
{
    public class SkillsListDto
    {
        public IList<Skills> Skills { get; set; }
    }
}
