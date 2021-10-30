using Microsoft.EntityFrameworkCore.Migrations;

namespace RA_SqlSever.Migrations
{
    public partial class fixrelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Finance_Residence_ResidenceId",
                schema: "Finance",
                table: "Finance");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Residence_ResidenceId",
                schema: "Main",
                table: "Property");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMember_Residence_ResidenceId",
                schema: "Main",
                table: "PropertyMember");

            migrationBuilder.DropIndex(
                name: "IX_Property_ResidenceId",
                schema: "Main",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "ResidenceId",
                schema: "Main",
                table: "Property");

            migrationBuilder.RenameColumn(
                name: "ResidenceId",
                schema: "Main",
                table: "PropertyMember",
                newName: "PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyMember_ResidenceId",
                schema: "Main",
                table: "PropertyMember",
                newName: "IX_PropertyMember_PropertyId");

            migrationBuilder.RenameColumn(
                name: "ResidenceId",
                schema: "Finance",
                table: "Finance",
                newName: "PropertyMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_Finance_ResidenceId",
                schema: "Finance",
                table: "Finance",
                newName: "IX_Finance_PropertyMemberId");

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                schema: "Main",
                table: "Residence",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Residence_PropertyId",
                schema: "Main",
                table: "Residence",
                column: "PropertyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Finance_PropertyMember_PropertyMemberId",
                schema: "Finance",
                table: "Finance",
                column: "PropertyMemberId",
                principalSchema: "Main",
                principalTable: "PropertyMember",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMember_Property_PropertyId",
                schema: "Main",
                table: "PropertyMember",
                column: "PropertyId",
                principalSchema: "Main",
                principalTable: "Property",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residence_Property_PropertyId",
                schema: "Main",
                table: "Residence",
                column: "PropertyId",
                principalSchema: "Main",
                principalTable: "Property",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Finance_PropertyMember_PropertyMemberId",
                schema: "Finance",
                table: "Finance");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMember_Property_PropertyId",
                schema: "Main",
                table: "PropertyMember");

            migrationBuilder.DropForeignKey(
                name: "FK_Residence_Property_PropertyId",
                schema: "Main",
                table: "Residence");

            migrationBuilder.DropIndex(
                name: "IX_Residence_PropertyId",
                schema: "Main",
                table: "Residence");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                schema: "Main",
                table: "Residence");

            migrationBuilder.RenameColumn(
                name: "PropertyId",
                schema: "Main",
                table: "PropertyMember",
                newName: "ResidenceId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyMember_PropertyId",
                schema: "Main",
                table: "PropertyMember",
                newName: "IX_PropertyMember_ResidenceId");

            migrationBuilder.RenameColumn(
                name: "PropertyMemberId",
                schema: "Finance",
                table: "Finance",
                newName: "ResidenceId");

            migrationBuilder.RenameIndex(
                name: "IX_Finance_PropertyMemberId",
                schema: "Finance",
                table: "Finance",
                newName: "IX_Finance_ResidenceId");

            migrationBuilder.AddColumn<int>(
                name: "ResidenceId",
                schema: "Main",
                table: "Property",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Property_ResidenceId",
                schema: "Main",
                table: "Property",
                column: "ResidenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Finance_Residence_ResidenceId",
                schema: "Finance",
                table: "Finance",
                column: "ResidenceId",
                principalSchema: "Main",
                principalTable: "Residence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Residence_ResidenceId",
                schema: "Main",
                table: "Property",
                column: "ResidenceId",
                principalSchema: "Main",
                principalTable: "Residence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMember_Residence_ResidenceId",
                schema: "Main",
                table: "PropertyMember",
                column: "ResidenceId",
                principalSchema: "Main",
                principalTable: "Residence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
