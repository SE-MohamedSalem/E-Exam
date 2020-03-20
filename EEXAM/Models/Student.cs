using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EExam.Models
{
    public class Student
    {
        public string id { set; get; }
        public string first_name { set; get; }
        public string last_name { set; get; }
        public string email { set; get; }
        public string address { set; get; }
        public string code { set; get; }
        public string password { set; get; }
        public Department dept { set; get; }
        public Faculty faculty { set; get; }
        public University university { set; get; }

        public int level { set; get; }
    }
}