using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderFoodTeam.Migrations
{
    public partial class updateord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    ReservationDate = table.Column<string>(nullable: true),
                    ReservationTime = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reserved = table.Column<bool>(nullable: false),
                    SeatsQuantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.id);
                });

            

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Productid = table.Column<int>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Product_Productid",
                        column: x => x.Productid,
                        principalTable: "Product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Productid",
                table: "Order",
                column: "Productid");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Table");

           

           
        }
    }
}
