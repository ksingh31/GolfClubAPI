using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfClub.API.Migrations
{
    public partial class MoreFieldsAndAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReservationID",
                table: "TeeTime",
                newName: "ReservationId");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "TeeTime",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "recRule",
                table: "TeeTime",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "approved",
                table: "Reservations",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "TeeTime");

            migrationBuilder.DropColumn(
                name: "recRule",
                table: "TeeTime");

            migrationBuilder.DropColumn(
                name: "approved",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "TeeTime",
                newName: "ReservationID");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
