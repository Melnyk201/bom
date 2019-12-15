using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderFoodTeam.Migrations
{
    public partial class _888 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Product_Productid",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_Productid",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Productid",
                table: "Order");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Productid",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_Productid",
                table: "Order",
                column: "Productid");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Product_Productid",
                table: "Order",
                column: "Productid",
                principalTable: "Product",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
