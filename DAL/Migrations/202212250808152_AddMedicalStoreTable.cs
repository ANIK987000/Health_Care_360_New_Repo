namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMedicalStoreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MedicalStores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                        SaleAmount = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MedicalStores");
        }
    }
}
