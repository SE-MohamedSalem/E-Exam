namespace EExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaptersaddedfacultylevelatrraddeddifflevelforquestionsadded_ : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        chapter_name = c.String(),
                        subject_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.SubjectExams", t => t.subject_id)
                .Index(t => t.subject_id);
            
            AddColumn("dbo.Questions", "Chapter_id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Questions", "Chapter_id");
            AddForeignKey("dbo.Questions", "Chapter_id", "dbo.Chapters", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chapters", "subject_id", "dbo.SubjectExams");
            DropForeignKey("dbo.Questions", "Chapter_id", "dbo.Chapters");
            DropIndex("dbo.Chapters", new[] { "subject_id" });
            DropIndex("dbo.Questions", new[] { "Chapter_id" });
            DropColumn("dbo.Questions", "Chapter_id");
            DropTable("dbo.Chapters");
        }
    }
}
