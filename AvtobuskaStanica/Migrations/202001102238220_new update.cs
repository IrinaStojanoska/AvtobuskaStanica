namespace AvtobuskaStanica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newupdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Relation_id", "dbo.Relations");
            DropIndex("dbo.Customers", new[] { "Relation_id" });
            RenameColumn(table: "dbo.Customers", name: "Relation_id", newName: "relationId");
            AlterColumn("dbo.Customers", "relationId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "relationId");
            AddForeignKey("dbo.Customers", "relationId", "dbo.Relations", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "relationId", "dbo.Relations");
            DropIndex("dbo.Customers", new[] { "relationId" });
            AlterColumn("dbo.Customers", "relationId", c => c.Int());
            RenameColumn(table: "dbo.Customers", name: "relationId", newName: "Relation_id");
            CreateIndex("dbo.Customers", "Relation_id");
            AddForeignKey("dbo.Customers", "Relation_id", "dbo.Relations", "id");
        }
    }
}
