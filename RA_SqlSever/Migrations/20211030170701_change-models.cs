using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RA_SqlSever.Migrations
{
    public partial class changemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_Member_FirstSideId",
                schema: "Main",
                table: "Property");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Member_SecondSideId",
                schema: "Main",
                table: "Property");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Residence_ResidenceId",
                schema: "Main",
                table: "Property");

            migrationBuilder.DropIndex(
                name: "IX_Property_FirstSideId",
                schema: "Main",
                table: "Property");

            migrationBuilder.DropIndex(
                name: "IX_Property_SecondSideId",
                schema: "Main",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "Date",
                schema: "Main",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "DecisionNumber",
                schema: "Main",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "FirstSideId",
                schema: "Main",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "ExpectedPrice",
                schema: "Main",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectCategory",
                schema: "Main",
                table: "Project");

            migrationBuilder.RenameColumn(
                name: "ResidenceType",
                schema: "Main",
                table: "Residence",
                newName: "FloorNumber");

            migrationBuilder.RenameColumn(
                name: "SecondSideId",
                schema: "Main",
                table: "Property",
                newName: "MembershipNumber");

            migrationBuilder.RenameColumn(
                name: "ProjectRegion",
                schema: "Main",
                table: "Project",
                newName: "ProjectLocation");

            migrationBuilder.RenameColumn(
                name: "AffiliationDate",
                schema: "Main",
                table: "Member",
                newName: "AcceptDate");

            migrationBuilder.AlterColumn<int>(
                name: "ResidenceId",
                schema: "Main",
                table: "Property",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Project_ID",
                schema: "Main",
                table: "Project",
                type: "nvarchar(200)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "PropertyMember",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DecisionNumber = table.Column<int>(type: "int", nullable: false),
                    ResidenceId = table.Column<int>(type: "int", nullable: false),
                    FirstSideId = table.Column<int>(type: "int", nullable: false),
                    SecondSideId = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyMember_Member_FirstSideId",
                        column: x => x.FirstSideId,
                        principalSchema: "Main",
                        principalTable: "Member",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PropertyMember_Member_SecondSideId",
                        column: x => x.SecondSideId,
                        principalSchema: "Main",
                        principalTable: "Member",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PropertyMember_Residence_ResidenceId",
                        column: x => x.ResidenceId,
                        principalSchema: "Main",
                        principalTable: "Residence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMember_FirstSideId",
                schema: "Main",
                table: "PropertyMember",
                column: "FirstSideId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMember_ResidenceId",
                schema: "Main",
                table: "PropertyMember",
                column: "ResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMember_SecondSideId",
                schema: "Main",
                table: "PropertyMember",
                column: "SecondSideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Residence_ResidenceId",
                schema: "Main",
                table: "Property",
                column: "ResidenceId",
                principalSchema: "Main",
                principalTable: "Residence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_Residence_ResidenceId",
                schema: "Main",
                table: "Property");

            migrationBuilder.DropTable(
                name: "PropertyMember",
                schema: "Main");

            migrationBuilder.RenameColumn(
                name: "FloorNumber",
                schema: "Main",
                table: "Residence",
                newName: "ResidenceType");

            migrationBuilder.RenameColumn(
                name: "MembershipNumber",
                schema: "Main",
                table: "Property",
                newName: "SecondSideId");

            migrationBuilder.RenameColumn(
                name: "ProjectLocation",
                schema: "Main",
                table: "Project",
                newName: "ProjectRegion");

            migrationBuilder.RenameColumn(
                name: "AcceptDate",
                schema: "Main",
                table: "Member",
                newName: "AffiliationDate");

            migrationBuilder.AlterColumn<int>(
                name: "ResidenceId",
                schema: "Main",
                table: "Property",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                schema: "Main",
                table: "Property",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DecisionNumber",
                schema: "Main",
                table: "Property",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FirstSideId",
                schema: "Main",
                table: "Property",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Project_ID",
                schema: "Main",
                table: "Project",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)");

            migrationBuilder.AddColumn<decimal>(
                name: "ExpectedPrice",
                schema: "Main",
                table: "Project",
                type: "decimal(20,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ProjectCategory",
                schema: "Main",
                table: "Project",
                type: "nvarchar(200)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Property_FirstSideId",
                schema: "Main",
                table: "Property",
                column: "FirstSideId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_SecondSideId",
                schema: "Main",
                table: "Property",
                column: "SecondSideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Member_FirstSideId",
                schema: "Main",
                table: "Property",
                column: "FirstSideId",
                principalSchema: "Main",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Member_SecondSideId",
                schema: "Main",
                table: "Property",
                column: "SecondSideId",
                principalSchema: "Main",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Residence_ResidenceId",
                schema: "Main",
                table: "Property",
                column: "ResidenceId",
                principalSchema: "Main",
                principalTable: "Residence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
