namespace EExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        address = c.String(),
                        code = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        faculty_id = c.String(maxLength: 128),
                        University_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Faculties", t => t.faculty_id)
                .ForeignKey("dbo.Universities", t => t.University_id)
                .Index(t => t.faculty_id)
                .Index(t => t.University_id);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        University_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Universities", t => t.University_id)
                .Index(t => t.University_id);
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SubjectExams",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        level = c.Int(nullable: false),
                        time_mins = c.Int(nullable: false),
                        dept_id = c.String(maxLength: 128),
                        profosser_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departments", t => t.dept_id)
                .ForeignKey("dbo.Professors", t => t.profosser_id)
                .Index(t => t.dept_id)
                .Index(t => t.profosser_id);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        address = c.String(),
                        code = c.String(),
                        password = c.String(),
                        dept = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        questionContent = c.String(),
                        isMCQ = c.Boolean(nullable: false),
                        choice1 = c.String(),
                        choice2 = c.String(),
                        choice3 = c.String(),
                        choice4 = c.String(),
                        answer = c.String(),
                        subjectExam_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.SubjectExams", t => t.subjectExam_id)
                .Index(t => t.subjectExam_id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        address = c.String(),
                        code = c.String(),
                        password = c.String(),
                        dept = c.String(),
                        level = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "University_id", "dbo.Universities");
            DropForeignKey("dbo.Questions", "subjectExam_id", "dbo.SubjectExams");
            DropForeignKey("dbo.SubjectExams", "profosser_id", "dbo.Professors");
            DropForeignKey("dbo.SubjectExams", "dept_id", "dbo.Departments");
            DropForeignKey("dbo.Faculties", "University_id", "dbo.Universities");
            DropForeignKey("dbo.Departments", "faculty_id", "dbo.Faculties");
            DropIndex("dbo.Questions", new[] { "subjectExam_id" });
            DropIndex("dbo.SubjectExams", new[] { "profosser_id" });
            DropIndex("dbo.SubjectExams", new[] { "dept_id" });
            DropIndex("dbo.Faculties", new[] { "University_id" });
            DropIndex("dbo.Departments", new[] { "University_id" });
            DropIndex("dbo.Departments", new[] { "faculty_id" });
            DropTable("dbo.Students");
            DropTable("dbo.Questions");
            DropTable("dbo.Professors");
            DropTable("dbo.SubjectExams");
            DropTable("dbo.Universities");
            DropTable("dbo.Faculties");
            DropTable("dbo.Departments");
            DropTable("dbo.Admins");
        }
    }
}
