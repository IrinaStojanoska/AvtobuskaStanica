namespace AvtobuskaStanica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newupdate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "relationId", "dbo.Relations");
            DropIndex("dbo.Customers", new[] { "relationId" });
            RenameColumn(table: "dbo.Customers", name: "relationId", newName: "Relation_id");
            AlterColumn("dbo.Customers", "Relation_id", c => c.Int());
            CreateIndex("dbo.Customers", "Relation_id");
            AddForeignKey("dbo.Customers", "Relation_id", "dbo.Relations", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Relation_id", "dbo.Relations");
            DropIndex("dbo.Customers", new[] { "Relation_id" });
            AlterColumn("dbo.Customers", "Relation_id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Customers", name: "Relation_id", newName: "relationId");
            CreateIndex("dbo.Customers", "relationId");
            AddForeignKey("dbo.Customers", "relationId", "dbo.Relations", "id", cascadeDelete: true);
        }
    }
}
