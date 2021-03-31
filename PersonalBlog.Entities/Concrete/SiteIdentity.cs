using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Entities.Concrete
{
    public class SiteIdentity : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string LogoText { get; set; }
        public string LogoFA { get; set; }
    }
}
