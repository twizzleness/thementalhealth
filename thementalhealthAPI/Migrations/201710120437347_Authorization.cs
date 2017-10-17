namespace thementalhealthAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Authorization : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "AuthToken", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "AuthToken");
        }
    }
}
