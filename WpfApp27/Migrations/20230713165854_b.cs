using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp27.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admindetails");

            migrationBuilder.CreateTable(
                name: "logindetails",
                columns: table => new
                {
                    regno = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    firstName = table.Column<string>(type: "TEXT", nullable: false),
                    lastName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logindetails", x => x.regno);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logindetails");

            migrationBuilder.CreateTable(
                name: "admindetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    aPassword = table.Column<string>(type: "TEXT", nullable: false),
                    aUsername = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admindetails", x => x.ID);
                });
        }
    }
}
