using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp27.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admintails",
                columns: table => new
                {
                    aUsername = table.Column<string>(type: "TEXT", nullable: false),
                    aPassword = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admintails", x => x.aUsername);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admintails");
        }
    }
}
