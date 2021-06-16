namespace ProjektST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentFirstName = c.String(),
                        StudentLastName = c.String(),
                        PhoneNumber = c.String(),
                        DateOfBirth = c.DateTime(),
                        Adress = c.String(),
                        AdressNumber = c.Int(nullable: false),
                        AdressNumber2 = c.Int(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                        LastLogin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
