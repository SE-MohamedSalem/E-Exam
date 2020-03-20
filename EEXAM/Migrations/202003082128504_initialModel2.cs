namespace EExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialModel2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "University_id", "dbo.Universities");
            DropIndex("dbo.Departments", new[] { "University_id" });
            DropIndex("dbo.Faculties", new[] { "University_id" });
            AddColumn("dbo.Admins", "faculty_id", c => c.String(maxLength: 128));
            AddColumn("dbo.Professors", "dept_id", c => c.String(maxLength: 128));
            AddColumn("dbo.Professors", "faculty_id", c => c.String(maxLength: 128));
            AddColumn("dbo.Professors", "university_id", c => c.String(maxLength: 128));
            AddColumn("dbo.Questions", "Professor_id", c => c.String(maxLength: 128));
            AddColumn("dbo.Students", "dept_id", c => c.String(maxLength: 128));
            AddColumn("dbo.Students", "faculty_id", c => c.String(maxLength: 128));
            AddColumn("dbo.Students", "university_id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Students", "level", c => c.Int(nullable: false));
            CreateIndex("dbo.Admins", "faculty_id");
            CreateIndex("dbo.Faculties", "university_id");
            CreateIndex("dbo.Professors", "dept_id");
            CreateIndex("dbo.Professors", "faculty_id");
            CreateIndex("dbo.Professors", "university_id");
            CreateIndex("dbo.Questions", "Professor_id");
            CreateIndex("dbo.Students", "dept_id");
            CreateIndex("dbo.Students", "faculty_id");
            CreateIndex("dbo.Students", "university_id");
            AddForeignKey("dbo.Professors", "dept_id", "dbo.Departments", "id");
            AddForeignKey("dbo.Professors", "faculty_id", "dbo.Faculties", "id");
            AddForeignKey("dbo.Questions", "Professor_id", "dbo.Professors", "id");
            AddForeignKey("dbo.Professors", "university_id", "dbo.Universities", "id");
            AddForeignKey("dbo.Students", "dept_id", "dbo.Departments", "id");
            AddForeignKey("dbo.Students", "faculty_id", "dbo.Faculties", "id");
            AddForeignKey("dbo.Students", "university_id", "dbo.Universities", "id");
            AddForeignKey("dbo.Admins", "faculty_id", "dbo.Faculties", "id");
            DropColumn("dbo.Departments", "University_id");
            DropColumn("dbo.Professors", "dept");
            DropColumn("dbo.Students", "dept");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "dept", c => c.String());
            AddColumn("dbo.Professors", "dept", c => c.String());
            AddColumn("dbo.Departments", "University_id", c => c.String(maxLength: 128));
            DropForeignKey("dbo.Admins", "faculty_id", "dbo.Faculties");
            DropForeignKey("dbo.Students", "university_id", "dbo.Universities");
            DropForeignKey("dbo.Students", "faculty_id", "dbo.Faculties");
            DropForeignKey("dbo.Students", "dept_id", "dbo.Departments");
            DropForeignKey("dbo.Professors", "university_id", "dbo.Universities");
            DropForeignKey("dbo.Questions", "Professor_id", "dbo.Professors");
            DropForeignKey("dbo.Professors", "faculty_id", "dbo.Faculties");
            DropForeignKey("dbo.Professors", "dept_id", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "university_id" });
            DropIndex("dbo.Students", new[] { "faculty_id" });
            DropIndex("dbo.Students", new[] { "dept_id" });
            DropIndex("dbo.Questions", new[] { "Professor_id" });
            DropIndex("dbo.Professors", new[] { "university_id" });
            DropIndex("dbo.Professors", new[] { "faculty_id" });
            DropIndex("dbo.Professors", new[] { "dept_id" });
            DropIndex("dbo.Faculties", new[] { "university_id" });
            DropIndex("dbo.Admins", new[] { "faculty_id" });
            AlterColumn("dbo.Students", "level", c => c.String());
            DropColumn("dbo.Students", "university_id");
            DropColumn("dbo.Students", "faculty_id");
            DropColumn("dbo.Students", "dept_id");
            DropColumn("dbo.Questions", "Professor_id");
            DropColumn("dbo.Professors", "university_id");
            DropColumn("dbo.Professors", "faculty_id");
            DropColumn("dbo.Professors", "dept_id");
            DropColumn("dbo.Admins", "faculty_id");
            CreateIndex("dbo.Faculties", "University_id");
            CreateIndex("dbo.Departments", "University_id");
            AddForeignKey("dbo.Departments", "University_id", "dbo.Universities", "id");
        }
    }
}
