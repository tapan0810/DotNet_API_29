using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNet_API_29.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pgs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PgDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PgLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PgContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PgOwner = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pgs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pgs");
        }
    }
}
