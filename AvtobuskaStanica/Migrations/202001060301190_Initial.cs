namespace AvtobuskaStanica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    serialNumber = c.Long(nullable: false),
                    name = c.String(nullable: false),
                    cardNumber = c.Long(nullable: false),
                })
                .PrimaryKey(t => t.id);

        }
        
        public override void Down()
        {
            DropTable("dbo.Relations");
            DropTable("dbo.Customers");
        }
    }
}
