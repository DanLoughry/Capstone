namespace PrsServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedattributestouservendorandproductclass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Partnumber", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "Unit", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Products", "Photopath", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Vendors", "Code", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Vendors", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Vendors", "Address", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Vendors", "City", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Vendors", "State", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Vendors", "Zip", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Vendors", "Phone", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Vendors", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Firstname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Lastname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Phone", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Phone", c => c.String());
            AlterColumn("dbo.Users", "Lastname", c => c.String());
            AlterColumn("dbo.Users", "Firstname", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String());
            AlterColumn("dbo.Vendors", "Email", c => c.String());
            AlterColumn("dbo.Vendors", "Phone", c => c.String());
            AlterColumn("dbo.Vendors", "Zip", c => c.String());
            AlterColumn("dbo.Vendors", "State", c => c.String());
            AlterColumn("dbo.Vendors", "City", c => c.String());
            AlterColumn("dbo.Vendors", "Address", c => c.String());
            AlterColumn("dbo.Vendors", "Name", c => c.String());
            AlterColumn("dbo.Vendors", "Code", c => c.String());
            AlterColumn("dbo.Products", "Photopath", c => c.String());
            AlterColumn("dbo.Products", "Unit", c => c.String());
            AlterColumn("dbo.Products", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Products", "Partnumber", c => c.String());
        }
    }
}
