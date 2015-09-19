namespace purse.domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDb_V2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckingAccounts",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        Title = c.String(),
                        CurrencyId = c.Guid(nullable: false),
                        Purse_id = c.Guid(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Purses", t => t.Purse_id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .Index(t => t.CurrencyId)
                .Index(t => t.Purse_id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        Title = c.String(),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CheckingAccount_id = c.Guid(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CheckingAccounts", t => t.CheckingAccount_id)
                .Index(t => t.CheckingAccount_id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Purses",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        Title = c.String(),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Client_id = c.Guid(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clients", t => t.Client_id)
                .Index(t => t.Client_id);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        Title = c.String(),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckingAccounts", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.Purses", "Client_id", "dbo.Clients");
            DropForeignKey("dbo.CheckingAccounts", "Purse_id", "dbo.Purses");
            DropForeignKey("dbo.Transactions", "CheckingAccount_id", "dbo.CheckingAccounts");
            DropIndex("dbo.Purses", new[] { "Client_id" });
            DropIndex("dbo.Transactions", new[] { "CheckingAccount_id" });
            DropIndex("dbo.CheckingAccounts", new[] { "Purse_id" });
            DropIndex("dbo.CheckingAccounts", new[] { "CurrencyId" });
            DropTable("dbo.Currencies");
            DropTable("dbo.Purses");
            DropTable("dbo.Clients");
            DropTable("dbo.Transactions");
            DropTable("dbo.CheckingAccounts");
        }
    }
}
