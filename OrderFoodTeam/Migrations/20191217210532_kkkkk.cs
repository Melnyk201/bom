using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderFoodTeam.Migrations
{
    public partial class kkkkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Product_Productid",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItem_Product_Productid",
                table: "ShopCartItem");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "ShopCartItem",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCartItem_Productid",
                table: "ShopCartItem",
                newName: "IX_ShopCartItem_ProductId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Product",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "OrderDetail",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_Productid",
                table: "OrderDetail",
                newName: "IX_OrderDetail_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Product_ProductId",
                table: "OrderDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItem_Product_ProductId",
                table: "ShopCartItem",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Product_ProductId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItem_Product_ProductId",
                table: "ShopCartItem");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ShopCartItem",
                newName: "Productid");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCartItem_ProductId",
                table: "ShopCartItem",
                newName: "IX_ShopCartItem_Productid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "OrderDetail",
                newName: "Productid");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_Productid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Product_Productid",
                table: "OrderDetail",
                column: "Productid",
                principalTable: "Product",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItem_Product_Productid",
                table: "ShopCartItem",
                column: "Productid",
                principalTable: "Product",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
