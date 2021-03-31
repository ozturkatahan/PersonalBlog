using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Entities.Dtos.SkillsDtos
{
    public class SkillsListDto
    {
        public IList<Skills> Skills { get; set; }
    }
}
