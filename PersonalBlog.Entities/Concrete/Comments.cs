using PersonalBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Entities.Concrete
{
    public class Comments : EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Text { get; set; }
        public int ArticleId { get; set; }
        public Articles Articles { get; set; }
    }
}
