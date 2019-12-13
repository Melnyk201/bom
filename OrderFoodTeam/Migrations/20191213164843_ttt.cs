using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderFoodTeam.Migrations
{
    public partial class ttt : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
