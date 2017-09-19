namespace Layer1.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddStudents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ChildFirstName = c.String(),
                        ChildLastName = c.String(),
                        DOB = c.String(),
                        ParentFatherName = c.String(),
                        ParentMotherName = c.String(),
                        ParentMobile = c.String(),
                        ParentEmailId = c.String(),
                        GuardianFirstName = c.String(),
                        GuardianLastName = c.String(),
                        GuardianRelation = c.String(),
                        GuardianMobile = c.String(),
                        GuardianEmailId = c.String(),
                        Address = c.String(),
                        Country = c.String(),
                        State = c.String(),
                        City = c.String(),
                        PostalCode = c.Int(nullable: false),
                        Enrolledclass = c.String(),
                        EnrolledRoom = c.String(),
                        EnrolledStartDate = c.String(),
                        EnrolledEndDate = c.String(),
                        AdditionalDetails = c.String(),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AddStudents");
        }
    }
}
