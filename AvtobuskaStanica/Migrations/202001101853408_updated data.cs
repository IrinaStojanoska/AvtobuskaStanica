namespace AvtobuskaStanica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateddata : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Email", c => c.String(maxLength: 256));
            DropColumn("dbo.AspNetUsers", "password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "password", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Email", c => c.String(nullable: false, maxLength: 256));
        }
    }
}
