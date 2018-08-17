namespace PrsServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class increasephotopathto250 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Photopath", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Photopath", c => c.String(maxLength: 50));
        }
    }
}
