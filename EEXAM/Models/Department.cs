using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EExam.Models
{
    public class Department
    {
        public String id {set; get;}
        public String name { set; get; }
        public IList<SubjectExam> subjectsExams { set; get; }
        public IList<Professor> Professors { set; get; }
        public IList<Student> Students { set; get; }
        public Faculty faculty { set; get; }
    }
}