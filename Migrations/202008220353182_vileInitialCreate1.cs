namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vileInitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "vileDescription", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "vileDescription");
        }
    }
}
