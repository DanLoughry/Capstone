namespace PrsServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedattributes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vendors", "Zip", c => c.String(nullable: false, maxLength: 9));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendors", "Zip", c => c.String(nullable: false, maxLength: 5));
        }
    }
}
