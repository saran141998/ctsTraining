using Microsoft.EntityFrameworkCore.Migrations;

namespace mvcTestCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    price = table.Column<double>(nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
