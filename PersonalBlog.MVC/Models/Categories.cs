using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.MVC.Models
{
    public class Categories
    {
        public string Name { get; set; }
        public string CategoryFA { get; set; }
        public string Description { get; set; }
        public ICollection<Articles> Articles { get; set; }
    }
}
