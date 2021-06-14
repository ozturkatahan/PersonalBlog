using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Service.Dtos.SlidersDtos
{
    public class SlidersListDto
    {
        public IList<HomePageSliders> Sliders { get; set; }
    }
}
