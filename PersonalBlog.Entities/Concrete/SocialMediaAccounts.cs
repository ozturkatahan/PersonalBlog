using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Entities.Concrete
{
    public class SocialMediaAccounts : EntityBase, IEntity
    {
        public string Account { get; set; }
        public string AccountFA { get; set; }
        public string AccountURL { get; set; }
    }
}
