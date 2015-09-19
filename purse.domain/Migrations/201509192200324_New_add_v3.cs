namespace purse.domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New_add_v3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.CheckingAccounts", new[] { "Currency_id" });
            AlterColumn("dbo.CheckingAccounts", "Currency_id", c => c.Guid());
            CreateIndex("dbo.CheckingAccounts", "Currency_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.CheckingAccounts", new[] { "Currency_id" });
            AlterColumn("dbo.CheckingAccounts", "Currency_id", c => c.Guid(nullable: false));
            CreateIndex("dbo.CheckingAccounts", "Currency_id");
        }
    }
}
