using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Service.Dtos.MessagesDtos
{
    public class MessagesListDto
    {
        public IList<Messages> Messages { get; set; }
    }
}
