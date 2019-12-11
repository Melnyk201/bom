using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderFoodTeam.Migrations
{
    public partial class newDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReservationDate",
                table: "Reservation",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Reservation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReservationTime",
                table: "Reservation",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "ReservationTime",
                table: "Reservation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
