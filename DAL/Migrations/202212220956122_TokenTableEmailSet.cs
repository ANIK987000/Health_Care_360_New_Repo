namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TokenTableEmailSet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "Email", c => c.String(nullable: false));
            DropColumn("dbo.Tokens", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tokens", "Username", c => c.String(nullable: false));
            DropColumn("dbo.Tokens", "Email");
        }
    }
}
