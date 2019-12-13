using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderFoodTeam.Migrations
{
    public partial class numbertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberTable",
                table: "Reservation",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberTable",
                table: "Reservation");
        }
    }
}
