namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "EmailAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "EmailAddress");
        }
    }
}
