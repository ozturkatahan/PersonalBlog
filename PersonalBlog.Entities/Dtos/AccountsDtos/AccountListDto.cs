﻿using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Entities.Dtos.AccountsDtos
{
    public class AccountListDto
    {
        public IList<SocialMediaAccounts> SocialMediaAccounts { get; set; }
    }
}
