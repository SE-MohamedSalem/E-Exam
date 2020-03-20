using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EExam.Models
{
    public class University
    {
        public String id { set; get; }
        public String name { set; get; }
        public IList<Faculty> faculties { set; get; }

    }
}