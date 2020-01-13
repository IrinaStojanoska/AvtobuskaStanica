namespace AvtobuskaStanica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedusertoroles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddUserToRoles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        selectedRole = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AddUserToRoles");
        }
    }
}
