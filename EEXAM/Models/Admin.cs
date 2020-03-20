using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EExam.Models
{
    public class Admin
    {
        public string id { set; get; }
        public string first_name { set; get; }
        public string last_name { set; get; }
        public string email { set; get; }
        public string address { set; get; }
        public string code { set; get; }
        public string password { set; get; }
        public Faculty faculty { set; get; }

    }
}
