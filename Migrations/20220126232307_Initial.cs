using Microsoft.EntityFrameworkCore.Migrations;

namespace McCordMission4Take2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieAdds",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: true),
                    Lent_To = table.Column<string>(nullable: true),
                    Note = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieAdds", x => x.ApplicationID);
                });

            migrationBuilder.InsertData(
                table: "MovieAdds",
                columns: new[] { "ApplicationID", "Category", "Director", "Edited", "Lent_To", "Note", "Rating", "Title" },
                values: new object[] { 1, "Comedy", "Rawson Thurber", true, "Connor Meadows", "This movie has been watched many a times in Newport Hills", "PG-13", "Dodgeball" });

            migrationBuilder.InsertData(
                table: "MovieAdds",
                columns: new[] { "ApplicationID", "Category", "Director", "Edited", "Lent_To", "Note", "Rating", "Title" },
                values: new object[] { 2, "Romantic-Comedy", "Jon M. Chu", false, null, null, "PG-13", "Crazy Rich Asians" });

            migrationBuilder.InsertData(
                table: "MovieAdds",
                columns: new[] { "ApplicationID", "Category", "Director", "Edited", "Lent_To", "Note", "Rating", "Title" },
                values: new object[] { 3, "Animation", "Jon M. Chu", false, null, null, "PG", "Mulan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieAdds");
        }
    }
}
