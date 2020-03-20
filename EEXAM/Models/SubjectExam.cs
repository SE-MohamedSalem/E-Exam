using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EExam.Models
{
    public class SubjectExam
    {
        public string id { set; get; }
        public string name { set; get; }
        public int level { set; get; }
        public Department dept { set; get; }
        public int time_mins { set; get; }
        public Professor profosser { set; get; }
        public IList<Chapter> chapters { set; get; }



    }
}