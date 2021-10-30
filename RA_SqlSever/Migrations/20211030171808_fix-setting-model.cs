using Microsoft.EntityFrameworkCore.Migrations;

namespace RA_SqlSever.Migrations
{
    public partial class fixsettingmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpectedPrice",
                schema: "Setting",
                table: "ExpectedPrice");

            migrationBuilder.RenameTable(
                name: "ExpectedPrice",
                schema: "Setting",
                newName: "Settings",
                newSchema: "Setting");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settings",
                schema: "Setting",
                table: "Settings",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Settings",
                schema: "Setting",
                table: "Settings");

            migrationBuilder.RenameTable(
                name: "Settings",
                schema: "Setting",
                newName: "ExpectedPrice",
                newSchema: "Setting");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpectedPrice",
                schema: "Setting",
                table: "ExpectedPrice",
                column: "Id");
        }
    }
}
