namespace BlackBooksApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PublishingHouseId = c.Int(nullable: false),
                    SupplierId = c.Int(nullable: false),
                    ISBN = c.String(unicode: false),
                    Name = c.String(unicode: false),
                    Author = c.String(unicode: false),
                    TypeId = c.Int(nullable: false),
                    Genre = c.String(unicode: false),
                    PublishingYear = c.Int(nullable: false),
                    Pages = c.Int(nullable: false),
                    CoverType = c.String(unicode: false),
                    BookPrice = c.Int(nullable: false),
                    SupplyDate = c.String(unicode: false),
                    Rest = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PublishingHouse", t => t.PublishingHouseId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Type", t => t.TypeId, cascadeDelete: true);
                //.Index(t => t.PublishingHouseId)
                //.Index(t => t.SupplierId)
                //.Index(t => t.TypeId);
            
            CreateTable(
                "dbo.PublishingHouse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Purchased",
                c => new
                {
                    Id = c.Int(nullable: false),
                    PurchaseId = c.Int(nullable: false),
                    BookId = c.Int(nullable: false),
                    OrderPrice = c.Int(nullable: false),
                    Number = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Book", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Purchase", t => t.PurchaseId, cascadeDelete: true);
            //.Index(t => t.PurchaseId)
            //.Index(t => t.BookId);

            CreateTable(
                "dbo.Purchase",
                c => new
                {
                    Id = c.Int(nullable: false),
                    EmployeeId = c.Int(nullable: false),
                    ClientId = c.Int(nullable: false),
                    DeliveryId = c.Int(nullable: false),
                    Ordate = c.String(unicode: false),
                    Address = c.String(unicode: false),
                    Delcost = c.Int(nullable: false),
                    Saledate = c.String(unicode: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Delivery", t => t.DeliveryId, cascadeDelete: true)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true);
                //.Index(t => t.EmployeeId)
                //.Index(t => t.ClientId)
                //.Index(t => t.DeliveryId);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Birthday = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Delivery",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                        Cost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Birthday = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                        Position = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        ContactPerson = c.String(unicode: false),
                        Position = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                        AboutCompany = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Type",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(unicode: false),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Book", "TypeId", "dbo.Type");
            DropForeignKey("dbo.Book", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Purchased", "PurchaseId", "dbo.Purchase");
            DropForeignKey("dbo.Purchase", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Purchase", "DeliveryId", "dbo.Delivery");
            DropForeignKey("dbo.Purchase", "ClientId", "dbo.Client");
            DropForeignKey("dbo.Purchased", "BookId", "dbo.Book");
            DropForeignKey("dbo.Book", "PublishingHouseId", "dbo.PublishingHouse");
            DropIndex("dbo.Purchase", new[] { "DeliveryId" });
            DropIndex("dbo.Purchase", new[] { "ClientId" });
            DropIndex("dbo.Purchase", new[] { "EmployeeId" });
            DropIndex("dbo.Purchased", new[] { "BookId" });
            DropIndex("dbo.Purchased", new[] { "PurchaseId" });
            DropIndex("dbo.Book", new[] { "TypeId" });
            DropIndex("dbo.Book", new[] { "SupplierId" });
            DropIndex("dbo.Book", new[] { "PublishingHouseId" });
            DropTable("dbo.Type");
            DropTable("dbo.Supplier");
            DropTable("dbo.Employee");
            DropTable("dbo.Delivery");
            DropTable("dbo.Client");
            DropTable("dbo.Purchase");
            DropTable("dbo.Purchased");
            DropTable("dbo.PublishingHouse");
            DropTable("dbo.Book");
        }
    }
}
