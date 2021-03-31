using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Entities.Concrete
{
    public class Skills : EntityBase, IEntity
    {
        public string Title { get; set; }
        public int PercentageValue { get; set; }
    }
}
