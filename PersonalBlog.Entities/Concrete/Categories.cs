using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Entities.Concrete
{
    public class Categories : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string CategoryFA { get; set; }
        public string Description { get; set; }
        public ICollection<Articles> Articles { get; set; }
    }
}
