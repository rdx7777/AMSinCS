using Microsoft.EntityFrameworkCore.Migrations;

namespace AMSinSC.DataAccess.Migrations
{
    public partial class UpdatedStorageContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbsenceCases_User_HeadTeacherId",
                table: "AbsenceCases");

            migrationBuilder.DropForeignKey(
                name: "FK_AbsenceCases_User_UserId",
                table: "AbsenceCases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbsenceCases_Users_HeadTeacherId",
                table: "AbsenceCases",
                column: "HeadTeacherId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbsenceCases_Users_UserId",
                table: "AbsenceCases",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbsenceCases_Users_HeadTeacherId",
                table: "AbsenceCases");

            migrationBuilder.DropForeignKey(
                name: "FK_AbsenceCases_Users_UserId",
                table: "AbsenceCases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbsenceCases_User_HeadTeacherId",
                table: "AbsenceCases",
                column: "HeadTeacherId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbsenceCases_User_UserId",
                table: "AbsenceCases",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
