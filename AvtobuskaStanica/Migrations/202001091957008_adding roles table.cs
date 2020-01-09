namespace AvtobuskaStanica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingrolestable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddToRoleModels",
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
            DropTable("dbo.AddToRoleModels");
        }
    }
}
