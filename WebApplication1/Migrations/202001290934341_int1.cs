namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class int1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Models", "SampleString", c => c.String());
            DropColumn("dbo.Models", "Amount");
            DropColumn("dbo.Models", "Date");
            DropColumn("dbo.Models", "FiscalAttribute");
            DropColumn("dbo.Models", "FiscalDocumentNumber");
            DropColumn("dbo.Models", "FiscalDriveNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Models", "FiscalDriveNumber", c => c.Long(nullable: false));
            AddColumn("dbo.Models", "FiscalDocumentNumber", c => c.Long(nullable: false));
            AddColumn("dbo.Models", "FiscalAttribute", c => c.Long(nullable: false));
            AddColumn("dbo.Models", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Models", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Models", "SampleString");
        }
    }
}
