using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp27.Migrations
{
    /// <inheritdoc />
    public partial class dfsdad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_admintails",
                table: "admintails");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "admintails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admintails",
                table: "admintails",
                column: "aUsername");

            migrationBuilder.CreateTable(
                name: "admindetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    aUsername = table.Column<string>(type: "TEXT", nullable: false),
                    aPassword = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admindetails", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admindetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admintails",
                table: "admintails");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "admintails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_admintails",
                table: "admintails",
                column: "ID");
        }
    }
}
