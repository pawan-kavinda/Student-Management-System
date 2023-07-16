using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp27.Migrations
{
    /// <inheritdoc />
    public partial class mvbc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "loginadmin",
                columns: table => new
                {
                    aUsername = table.Column<string>(type: "TEXT", nullable: false),
                    aPassword = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loginadmin", x => x.aUsername);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "loginadmin");
        }
    }
}
