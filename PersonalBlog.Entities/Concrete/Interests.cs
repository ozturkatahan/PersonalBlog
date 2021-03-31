using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Entities.Concrete
{
    public class Interests : EntityBase, IEntity
    {
        public string Text { get; set; }
    }
}
