using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderFoodTeam.Migrations
{
    public partial class Nazva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Table_Tableid",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_Tableid",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "Tableid",
                table: "Reservation");

            migrationBuilder.AddColumn<int>(
                name: "qantity",
                table: "Reservation",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "qantity",
                table: "Reservation");

            migrationBuilder.AddColumn<int>(
                name: "Tableid",
                table: "Reservation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_Tableid",
                table: "Reservation",
                column: "Tableid");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Table_Tableid",
                table: "Reservation",
                column: "Tableid",
                principalTable: "Table",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
