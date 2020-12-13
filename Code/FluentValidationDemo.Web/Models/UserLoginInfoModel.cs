using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationDemo.Web.Models
{
    public class UserLoginInfoModel
    {
        public string UserName { get; set; }

        public string Pwd { get; set; }
    }
}