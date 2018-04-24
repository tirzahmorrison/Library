namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRoleToReader : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Readers", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Readers", "Role");
        }
    }
}
