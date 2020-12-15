namespace Sparen.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMoreFieldsToUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ApplicationUser", "FirstName", c => c.String());
            AlterColumn("dbo.ApplicationUser", "LastName", c => c.String());
            DropColumn("dbo.ApplicationUser", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ApplicationUser", "Phone", c => c.String());
            AlterColumn("dbo.ApplicationUser", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.ApplicationUser", "FirstName", c => c.String(nullable: false));
        }
    }
}
