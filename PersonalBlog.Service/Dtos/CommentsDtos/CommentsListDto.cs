using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Service.Dtos.CommentsDtos
{
    public class CommentsListDto
    {
        public IList<Comments> Comments { get; set; }
    }
}
