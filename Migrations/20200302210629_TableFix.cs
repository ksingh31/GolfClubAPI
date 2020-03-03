using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfClub.API.Migrations
{
    public partial class TableFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TeeTime",
                table: "TeeTime");

            migrationBuilder.DropColumn(
                name: "TeeTimeID",
                table: "TeeTime");

            migrationBuilder.DropColumn(
                name: "EndDateTime",
                table: "TeeTime");

            migrationBuilder.DropColumn(
                name: "StartDateTime",
                table: "TeeTime");

            migrationBuilder.DropColumn(
                name: "recRule",
                table: "TeeTime");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TeeTime",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "TeeTime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RecurrenceRule",
                table: "TeeTime",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "TeeTime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeeTime",
                table: "TeeTime",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TeeTime_ReservationId",
                table: "TeeTime",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeeTime_Reservations_ReservationId",
                table: "TeeTime",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeeTime_Reservations_ReservationId",
                table: "TeeTime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeeTime",
                table: "TeeTime");

            migrationBuilder.DropIndex(
                name: "IX_TeeTime_ReservationId",
                table: "TeeTime");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TeeTime");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "TeeTime");

            migrationBuilder.DropColumn(
                name: "RecurrenceRule",
                table: "TeeTime");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "TeeTime");

            migrationBuilder.AddColumn<int>(
                name: "TeeTimeID",
                table: "TeeTime",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateTime",
                table: "TeeTime",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateTime",
                table: "TeeTime",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "recRule",
                table: "TeeTime",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeeTime",
                table: "TeeTime",
                column: "TeeTimeID");
        }
    }
}
