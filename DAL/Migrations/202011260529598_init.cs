namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        IdCustomer = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        CustomerName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.IdCustomer);
            
            CreateTable(
                "dbo.ListRenteds",
                c => new
                    {
                        IdListRented = c.Int(nullable: false, identity: true),
                        IdDisk = c.Int(nullable: false),
                        IdCustomer = c.Int(nullable: false),
                        LateFee = c.Double(nullable: false),
                        RentalDate = c.DateTime(nullable: false),
                        ExpectedReturnDate = c.DateTime(nullable: false),
                        ActualReturnDate = c.DateTime(nullable: false),
                        StatusOnBill = c.String(),
                    })
                .PrimaryKey(t => t.IdListRented)
                .ForeignKey("dbo.Customers", t => t.IdCustomer, cascadeDelete: true)
                .ForeignKey("dbo.Disks", t => t.IdDisk, cascadeDelete: true)
                .Index(t => t.IdDisk)
                .Index(t => t.IdCustomer);
            
            CreateTable(
                "dbo.Disks",
                c => new
                    {
                        IdDisk = c.Int(nullable: false, identity: true),
                        IdTitle = c.Int(nullable: false),
                        DiskRentalStatus = c.Int(nullable: false),
                        DiskStatus = c.String(),
                    })
                .PrimaryKey(t => t.IdDisk)
                .ForeignKey("dbo.Titles", t => t.IdTitle, cascadeDelete: true)
                .Index(t => t.IdTitle);
            
            CreateTable(
                "dbo.Titles",
                c => new
                    {
                        IdTitle = c.Int(nullable: false, identity: true),
                        IdDiskType = c.Int(nullable: false),
                        NameTitle = c.String(),
                        TotalDisk = c.Int(nullable: false),
                        TotalDiskOnShelf = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdTitle)
                .ForeignKey("dbo.DiskTypes", t => t.IdDiskType, cascadeDelete: true)
                .Index(t => t.IdDiskType);
            
            CreateTable(
                "dbo.DiskTypes",
                c => new
                    {
                        IdDiskType = c.Int(nullable: false, identity: true),
                        TypeName = c.Int(nullable: false),
                        TimeRented = c.Int(nullable: false),
                        LateFee = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdDiskType);
            
            CreateTable(
                "dbo.ListTitlePreOrders",
                c => new
                    {
                        IdListTitlePreOrder = c.Int(nullable: false, identity: true),
                        IdCustomer = c.Int(nullable: false),
                        IdTitle = c.Int(nullable: false),
                        NumberOfDisk = c.Int(nullable: false),
                        StatusProcess = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdListTitlePreOrder)
                .ForeignKey("dbo.Customers", t => t.IdCustomer, cascadeDelete: true)
                .ForeignKey("dbo.Titles", t => t.IdTitle, cascadeDelete: true)
                .Index(t => t.IdCustomer)
                .Index(t => t.IdTitle);
            
            CreateTable(
                "dbo.DetailPreOrders",
                c => new
                    {
                        IdDetailPreOrder = c.Int(nullable: false, identity: true),
                        IdCustomer = c.Int(nullable: false),
                        IdDisk = c.Int(nullable: false),
                        IdListTitlePreOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDetailPreOrder)
                .ForeignKey("dbo.Customers", t => t.IdCustomer, cascadeDelete: true)
                .ForeignKey("dbo.Disks", t => t.IdDisk, cascadeDelete: true)
                .ForeignKey("dbo.ListTitlePreOrders", t => t.IdListTitlePreOrder, cascadeDelete: false)
                .Index(t => t.IdCustomer)
                .Index(t => t.IdDisk)
                .Index(t => t.IdListTitlePreOrder);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ListTitlePreOrders", "IdTitle", "dbo.Titles");
            DropForeignKey("dbo.DetailPreOrders", "IdListTitlePreOrder", "dbo.ListTitlePreOrders");
            DropForeignKey("dbo.DetailPreOrders", "IdDisk", "dbo.Disks");
            DropForeignKey("dbo.DetailPreOrders", "IdCustomer", "dbo.Customers");
            DropForeignKey("dbo.ListTitlePreOrders", "IdCustomer", "dbo.Customers");
            DropForeignKey("dbo.ListRenteds", "IdDisk", "dbo.Disks");
            DropForeignKey("dbo.Titles", "IdDiskType", "dbo.DiskTypes");
            DropForeignKey("dbo.Disks", "IdTitle", "dbo.Titles");
            DropForeignKey("dbo.ListRenteds", "IdCustomer", "dbo.Customers");
            DropIndex("dbo.DetailPreOrders", new[] { "IdListTitlePreOrder" });
            DropIndex("dbo.DetailPreOrders", new[] { "IdDisk" });
            DropIndex("dbo.DetailPreOrders", new[] { "IdCustomer" });
            DropIndex("dbo.ListTitlePreOrders", new[] { "IdTitle" });
            DropIndex("dbo.ListTitlePreOrders", new[] { "IdCustomer" });
            DropIndex("dbo.Titles", new[] { "IdDiskType" });
            DropIndex("dbo.Disks", new[] { "IdTitle" });
            DropIndex("dbo.ListRenteds", new[] { "IdCustomer" });
            DropIndex("dbo.ListRenteds", new[] { "IdDisk" });
            DropTable("dbo.DetailPreOrders");
            DropTable("dbo.ListTitlePreOrders");
            DropTable("dbo.DiskTypes");
            DropTable("dbo.Titles");
            DropTable("dbo.Disks");
            DropTable("dbo.ListRenteds");
            DropTable("dbo.Customers");
        }
    }
}
