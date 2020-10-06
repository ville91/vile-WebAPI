namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vileInitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Address = c.String(nullable: false, maxLength: 120),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Price = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 150),
                        ManufacturerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .Index(t => t.ManufacturerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.Products", new[] { "ManufacturerId" });
            DropTable("dbo.Products");
            DropTable("dbo.Manufacturers");
        }
    }
}
