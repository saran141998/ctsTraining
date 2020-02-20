namespace BookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(nullable: false, maxLength: 250),
                        Address = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        price = c.Double(nullable: false),
                        Genre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.BookId);
            
            CreateTable(
                "dbo.Detail",
                c => new
                    {
                        DetailId = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetailId)
                .ForeignKey("dbo.Author", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Book", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Detail", "BookId", "dbo.Book");
            DropForeignKey("dbo.Detail", "AuthorId", "dbo.Author");
            DropIndex("dbo.Detail", new[] { "AuthorId" });
            DropIndex("dbo.Detail", new[] { "BookId" });
            DropTable("dbo.Detail");
            DropTable("dbo.Book");
            DropTable("dbo.Author");
        }
    }
}
