namespace AmmarahKader_XactERP_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        iAccountCode = c.String(),
                        iDate = c.String(),
                        iTotalSell = c.String(),
                        iVat = c.String(),
                        iNumber = c.String(),
                        iItemNumber = c.String(),
                        iStockCode = c.String(),
                        iQtySold = c.Int(nullable: false),
                        iUnitCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        iUnitSell = c.Decimal(nullable: false, precision: 18, scale: 2),
                        iDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        iTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        iTransactionType = c.String(),
                        iDocumentNumber = c.String(),
                    })
                .PrimaryKey(t => t.InvoiceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Invoices");
        }
    }
}
