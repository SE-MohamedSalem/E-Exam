using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EExam.Models
{
    public class EExamContext : DbContext
    {
        public DbSet<Admin> admins { set; get; }
        public DbSet<Professor> profossers { set; get; }
        public DbSet<Student> students { set; get; }
        public DbSet<SubjectExam> subjectsExam { set; get; }
        public DbSet<Department> departments { set; get; }
        public DbSet<Faculty> faculties { set; get; }
        public DbSet<University> universities { set; get; }
        public DbSet<Question> questions { set; get; }
        public DbSet<Chapter> chapters { set; get; }

        public EExamContext()
            :base("name=DefaultConnection")
        { 
           
        }

    }
}