namespace purse.domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteClientRole : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ClientRoles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ClientRoles",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        ClientId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
    }
}
