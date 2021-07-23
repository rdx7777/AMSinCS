using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AMSinSC.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbsenceCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    HeadTeacherId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PartDayType = table.Column<int>(type: "int", nullable: false),
                    AbsenceReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCoverRequired = table.Column<int>(type: "int", nullable: false),
                    IsCoverProvided = table.Column<int>(type: "int", nullable: false),
                    CoverSupervisorComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApprovedByHeadTeacher = table.Column<int>(type: "int", nullable: false),
                    IsAbsencePaid = table.Column<int>(type: "int", nullable: false),
                    HeadTeacherComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HrSupervisorComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCaseResolved = table.Column<int>(type: "int", nullable: false),
                    ResolvedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbsenceCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbsenceCases_User_HeadTeacherId",
                        column: x => x.HeadTeacherId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbsenceCases_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbsenceCases_HeadTeacherId",
                table: "AbsenceCases",
                column: "HeadTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_AbsenceCases_UserId",
                table: "AbsenceCases",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbsenceCases");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
