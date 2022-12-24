namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "VisitingHours", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Doctors", "AppointmentFee", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Patients", "Disease", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Staffs", "Salary", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Patients", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Patients", "Description", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Staffs", "Salary");
            DropColumn("dbo.Patients", "Disease");
            DropColumn("dbo.Doctors", "AppointmentFee");
            DropColumn("dbo.Doctors", "VisitingHours");
        }
    }
}
