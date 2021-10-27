using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RA_SqlSever.Migrations
{
    public partial class setDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Setting");

            migrationBuilder.EnsureSchema(
                name: "Finance");

            migrationBuilder.EnsureSchema(
                name: "Main");

            migrationBuilder.CreateTable(
                name: "ExpectedPrice",
                schema: "Setting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlyPremium = table.Column<decimal>(type: "decimal(20,3)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpectedPrice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpectedPrice = table.Column<decimal>(type: "decimal(20,3)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Project_ID = table.Column<int>(type: "int", nullable: false),
                    ProjectRegion = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    ProjectCategory = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Residence",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Residence_ID = table.Column<int>(type: "int", nullable: false),
                    ResidenceAddress = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    SectionNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ResidenceType = table.Column<int>(type: "int", nullable: false),
                    ResidenceDirection = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    RecordNumber = table.Column<int>(type: "int", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedCost = table.Column<decimal>(type: "decimal(20,3)", nullable: false),
                    FinalCost = table.Column<decimal>(type: "decimal(20,3)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Residence_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalSchema: "Main",
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Finance",
                schema: "Finance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinanceType = table.Column<int>(type: "int", nullable: false),
                    BillNumber = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(20,3)", nullable: false),
                    ResidenceId = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Finance_Residence_ResidenceId",
                        column: x => x.ResidenceId,
                        principalSchema: "Main",
                        principalTable: "Residence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SocialStatus = table.Column<int>(type: "int", nullable: false),
                    RegistrationNumber = table.Column<int>(type: "int", nullable: false),
                    IsMarried = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    JobAddress = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Income = table.Column<decimal>(type: "decimal(15,5)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Member_ID = table.Column<int>(type: "int", nullable: false),
                    AffiliationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionNumber = table.Column<int>(type: "int", nullable: false),
                    DesisionNumber = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<int>(type: "int", nullable: false),
                    MembershipExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Member_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Main",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Property",
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
                    table.PrimaryKey("PK_Property", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_Member_FirstSideId",
                        column: x => x.FirstSideId,
                        principalSchema: "Main",
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Property_Member_SecondSideId",
                        column: x => x.SecondSideId,
                        principalSchema: "Main",
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_Residence_ResidenceId",
                        column: x => x.ResidenceId,
                        principalSchema: "Main",
                        principalTable: "Residence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Finance_ResidenceId",
                schema: "Finance",
                table: "Finance",
                column: "ResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_PersonId",
                schema: "Main",
                table: "Member",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_MemberId",
                schema: "Main",
                table: "Person",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_FirstSideId",
                schema: "Main",
                table: "Property",
                column: "FirstSideId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_ResidenceId",
                schema: "Main",
                table: "Property",
                column: "ResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_SecondSideId",
                schema: "Main",
                table: "Property",
                column: "SecondSideId");

            migrationBuilder.CreateIndex(
                name: "IX_Residence_ProjectId",
                schema: "Main",
                table: "Residence",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Member_MemberId",
                schema: "Main",
                table: "Person",
                column: "MemberId",
                principalSchema: "Main",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_Person_PersonId",
                schema: "Main",
                table: "Member");

            migrationBuilder.DropTable(
                name: "ExpectedPrice",
                schema: "Setting");

            migrationBuilder.DropTable(
                name: "Finance",
                schema: "Finance");

            migrationBuilder.DropTable(
                name: "Property",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Residence",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Project",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Member",
                schema: "Main");
        }
    }
}
