namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HospitalNameChangeToAdmin : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Hospitals", newName: "Admins");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Admins", newName: "Hospitals");
        }
    }
}
