﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStronglyTypedHtmlHelper.Models
{
    public class SignUp
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string UserComment { get; set; }
    }
}