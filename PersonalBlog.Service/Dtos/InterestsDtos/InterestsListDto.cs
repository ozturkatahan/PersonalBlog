using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Service.Dtos.InterestsDtos
{
    public class InterestsListDto
    {
        public IList<Interests> Interests { get; set; }
    }
}
