namespace AvtobuskaStanica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedRelationCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Relation_id", c => c.Int());
            CreateIndex("dbo.Customers", "Relation_id");
            AddForeignKey("dbo.Customers", "Relation_id", "dbo.Relations", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Relation_id", "dbo.Relations");
            DropIndex("dbo.Customers", new[] { "Relation_id" });
            DropColumn("dbo.Customers", "Relation_id");
        }
    }
}
