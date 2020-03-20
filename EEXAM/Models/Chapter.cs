using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EExam.Models
{
    public class Chapter
    {
        public String id { set; get; }
        public String chapter_name { set; get; }
        public SubjectExam subject { set; get; }
        public IList<Question> questions { set; get; }
    }
}