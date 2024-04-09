namespace AmmarahKader_XactERP_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Debtors",
                c => new
                    {
                        DebtorId = c.Int(nullable: false, identity: true),
                        dAccountCode = c.String(),
                        dAddressOne = c.String(),
                        dAddressTwo = c.String(),
                        dAddressThree = c.String(),
                        dCategory = c.String(),
                        dInvoiceType = c.String(),
                        dContactNumberOne = c.String(),
                        dContactNumberTwo = c.String(),
                        dBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dSalesYearToDte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dCostYearToDate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dCreditLimit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.DebtorId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        sCode = c.String(),
                        sDescriptionOne = c.String(),
                        sDescriptionTwo = c.String(),
                        sCategory = c.String(),
                        sInvoiceType = c.String(),
                        sCostPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sSellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sTotalPurchases = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sTotalSales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sQtyPurchased = c.Int(nullable: false),
                        sQtySold = c.Int(nullable: false),
                        sOnHand = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StockId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        uName = c.String(),
                        uSurname = c.String(),
                        uEmailAddress = c.String(),
                        uContactNumber = c.String(),
                        uUsername = c.String(),
                        uPassword = c.String(),
                        uConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Stocks");
            DropTable("dbo.Debtors");
        }
    }
}
