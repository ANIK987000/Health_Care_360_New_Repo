namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NoticeBoards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Appointments", "AppointmentFee", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Admins", "Phone", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Admins", "Address", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Tokens", "Type", c => c.String(nullable: false));
            DropColumn("dbo.Admins", "Location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "Location", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Tokens", "Type");
            DropColumn("dbo.Admins", "Address");
            DropColumn("dbo.Admins", "Phone");
            DropColumn("dbo.Appointments", "AppointmentFee");
            DropTable("dbo.NoticeBoards");
        }
    }
}
