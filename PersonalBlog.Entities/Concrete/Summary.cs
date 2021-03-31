using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Entities.Concrete
{
    public class Summary : EntityBase, IEntity
    {
        public string Content { get; set; }
    }
}
