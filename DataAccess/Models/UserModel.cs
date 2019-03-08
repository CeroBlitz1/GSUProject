﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public int UserTypeID { get; set; }
        public string UMessage { get; set; }
        public bool UFlag { get; set; }
        public string ReturnUrl { get; set; }
        public int isDelete { get; set; }
    }
}
