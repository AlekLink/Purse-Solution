namespace purse.domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_RoleClientRole : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Roles");
            DropTable("dbo.ClientRoles");
        }
    }
}
