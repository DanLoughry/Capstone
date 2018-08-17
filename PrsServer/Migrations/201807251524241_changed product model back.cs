namespace PrsServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedproductmodelback : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Unit", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Unit", c => c.String(maxLength: 50));
        }
    }
}
