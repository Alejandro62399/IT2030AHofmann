namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        EnrollmentId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                        StudentObject = c.Int(nullable: false),
                        CourseObject = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnrollmentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Enrollments");
        }
    }
}
