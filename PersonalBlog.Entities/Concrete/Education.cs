using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Entities.Concrete
{
    public class Education : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string SchoolName { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }

    }
}
