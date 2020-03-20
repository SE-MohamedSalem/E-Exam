using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EExam.Models
{
    public class Question
    {
        public String id { set; get; }
        public String questionContent { set; get; }
        public bool isMCQ { set; get; }
        public String choice1 { set; get; }
        public String choice2 { set; get; }
        public String choice3 { set; get; }
        public String choice4 { set; get; }
        public String answer { set; get; }
        public SubjectExam subjectExam { set; get; }
        public int diff_level { set; get; }


    }
   
}