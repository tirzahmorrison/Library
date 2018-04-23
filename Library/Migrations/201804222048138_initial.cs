namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Born = c.String(),
                        Died = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IsCheckedOut = c.Boolean(nullable: false),
                        DueBackDate = c.DateTime(nullable: false),
                        BooksDataId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BooksDatas", t => t.BooksDataId)
                .Index(t => t.BooksDataId);
            
            CreateTable(
                "dbo.BooksDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        YearPublished = c.Int(nullable: false),
                        Condition = c.String(),
                        IsbnNumber = c.String(),
                        AuthorId = c.Int(),
                        GenreId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.AuthorId)
                .ForeignKey("dbo.Genres", t => t.GenreId)
                .Index(t => t.AuthorId)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DisplayName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CheckOuts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TimeStamp = c.DateTime(nullable: false),
                        AuthorId = c.Int(),
                        BooksId = c.Int(),
                        ReaderId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.AuthorId)
                .ForeignKey("dbo.Books", t => t.BooksId)
                .ForeignKey("dbo.Readers", t => t.ReaderId)
                .Index(t => t.AuthorId)
                .Index(t => t.BooksId)
                .Index(t => t.ReaderId);
            
            CreateTable(
                "dbo.Readers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReaderName = c.String(),
                        Email = c.String(),
                        CardNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckOuts", "ReaderId", "dbo.Readers");
            DropForeignKey("dbo.CheckOuts", "BooksId", "dbo.Books");
            DropForeignKey("dbo.CheckOuts", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Books", "BooksDataId", "dbo.BooksDatas");
            DropForeignKey("dbo.BooksDatas", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.BooksDatas", "AuthorId", "dbo.Authors");
            DropIndex("dbo.CheckOuts", new[] { "ReaderId" });
            DropIndex("dbo.CheckOuts", new[] { "BooksId" });
            DropIndex("dbo.CheckOuts", new[] { "AuthorId" });
            DropIndex("dbo.BooksDatas", new[] { "GenreId" });
            DropIndex("dbo.BooksDatas", new[] { "AuthorId" });
            DropIndex("dbo.Books", new[] { "BooksDataId" });
            DropTable("dbo.Readers");
            DropTable("dbo.CheckOuts");
            DropTable("dbo.Genres");
            DropTable("dbo.BooksDatas");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
