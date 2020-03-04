using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfClub.API.Migrations
{
    public partial class Fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "NumberOfPlayers",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "RecurrenceRule",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "approved",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Reservations",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Reservations",
                newName: "subject");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Reservations",
                newName: "startTime");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Reservations",
                newName: "endTime");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_UserID",
                table: "Reservations",
                newName: "IX_Reservations_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reservations",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "approval",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "noOfPlayers",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "recurringData",
                table: "Reservations",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "approval",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "noOfPlayers",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "recurringData",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "subject",
                table: "Reservations",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "startTime",
                table: "Reservations",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "endTime",
                table: "Reservations",
                newName: "EndTime");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reservations",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                newName: "IX_Reservations_UserID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPlayers",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RecurrenceRule",
                table: "Reservations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "approved",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserID",
                table: "Reservations",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
