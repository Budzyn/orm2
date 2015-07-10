namespace MyEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ggg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asks",
                c => new
                    {
                        AskID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        NameAsk = c.String(),
                    })
                .PrimaryKey(t => t.AskID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Lectures",
                c => new
                    {
                        LectureID = c.Int(nullable: false, identity: true),
                        TeacherID = c.Int(nullable: false),
                        Name = c.String(),
                        Category = c.String(),
                        Discriptions = c.String(),
                    })
                .PrimaryKey(t => t.LectureID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        TestID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category = c.String(),
                        ListAsk = c.String(),
                        TimeMax = c.Int(nullable: false),
                        Pass = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TestID);
            
            CreateTable(
                "dbo.DoTests",
                c => new
                    {
                        DoTestID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserID = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        Time = c.Int(nullable: false),
                        Tests_TestID = c.Int(),
                    })
                .PrimaryKey(t => t.DoTestID)
                .ForeignKey("dbo.Tests", t => t.Tests_TestID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.Tests_TestID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        City = c.String(),
                        University = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.TeacherLectures",
                c => new
                    {
                        Teacher_TeacherID = c.Int(nullable: false),
                        Lecture_LectureID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_TeacherID, t.Lecture_LectureID })
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherID, cascadeDelete: true)
                .ForeignKey("dbo.Lectures", t => t.Lecture_LectureID, cascadeDelete: true)
                .Index(t => t.Teacher_TeacherID)
                .Index(t => t.Lecture_LectureID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DoTests", "UserID", "dbo.Users");
            DropForeignKey("dbo.DoTests", "Tests_TestID", "dbo.Tests");
            DropForeignKey("dbo.TeacherLectures", "Lecture_LectureID", "dbo.Lectures");
            DropForeignKey("dbo.TeacherLectures", "Teacher_TeacherID", "dbo.Teachers");
            DropIndex("dbo.TeacherLectures", new[] { "Lecture_LectureID" });
            DropIndex("dbo.TeacherLectures", new[] { "Teacher_TeacherID" });
            DropIndex("dbo.DoTests", new[] { "Tests_TestID" });
            DropIndex("dbo.DoTests", new[] { "UserID" });
            DropTable("dbo.TeacherLectures");
            DropTable("dbo.Users");
            DropTable("dbo.DoTests");
            DropTable("dbo.Tests");
            DropTable("dbo.Teachers");
            DropTable("dbo.Lectures");
            DropTable("dbo.Categories");
            DropTable("dbo.Asks");
        }
    }
}
