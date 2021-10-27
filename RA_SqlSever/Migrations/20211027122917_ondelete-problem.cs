using Microsoft.EntityFrameworkCore.Migrations;

namespace RA_SqlSever.Migrations
{
    public partial class ondeleteproblem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_Member_FirstSideId",
                schema: "Main",
                table: "Property");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Member_FirstSideId",
                schema: "Main",
                table: "Property",
                column: "FirstSideId",
                principalSchema: "Main",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_Member_FirstSideId",
                schema: "Main",
                table: "Property");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Member_FirstSideId",
                schema: "Main",
                table: "Property",
                column: "FirstSideId",
                principalSchema: "Main",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
