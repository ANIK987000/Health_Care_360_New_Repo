namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAdminTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Phone", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Admins", "Address", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Admins", "Location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "Location", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Admins", "Address");
            DropColumn("dbo.Admins", "Phone");
        }
    }
}
