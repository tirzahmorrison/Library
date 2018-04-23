namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movedConditionFromBooksDbToBooks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Condition", c => c.String());
            DropColumn("dbo.BooksDatas", "Condition");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BooksDatas", "Condition", c => c.String());
            DropColumn("dbo.Books", "Condition");
        }
    }
}
