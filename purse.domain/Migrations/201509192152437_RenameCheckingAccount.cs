namespace purse.domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCheckingAccount : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CheckingAccounts", "CurrencyId", "dbo.Currencies");
            DropIndex("dbo.CheckingAccounts", new[] { "CurrencyId" });
            RenameColumn(table: "dbo.CheckingAccounts", name: "CurrencyId", newName: "Currency_id");
            AlterColumn("dbo.CheckingAccounts", "Currency_id", c => c.Guid());
            CreateIndex("dbo.CheckingAccounts", "Currency_id");
            AddForeignKey("dbo.CheckingAccounts", "Currency_id", "dbo.Currencies", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckingAccounts", "Currency_id", "dbo.Currencies");
            DropIndex("dbo.CheckingAccounts", new[] { "Currency_id" });
            AlterColumn("dbo.CheckingAccounts", "Currency_id", c => c.Guid(nullable: false));
            RenameColumn(table: "dbo.CheckingAccounts", name: "Currency_id", newName: "CurrencyId");
            CreateIndex("dbo.CheckingAccounts", "CurrencyId");
            AddForeignKey("dbo.CheckingAccounts", "CurrencyId", "dbo.Currencies", "id", cascadeDelete: true);
        }
    }
}
