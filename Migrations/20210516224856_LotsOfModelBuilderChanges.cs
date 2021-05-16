using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice2.Migrations
{
    public partial class LotsOfModelBuilderChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    ItemName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => new { x.OrderId, x.ItemName, x.Price });
                    table.ForeignKey(
                        name: "FK_OrderItem_Items_ItemName_Price",
                        columns: x => new { x.ItemName, x.Price },
                        principalTable: "Items",
                        principalColumns: new[] { "ItemName", "Price" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ItemName_Price",
                table: "OrderItem",
                columns: new[] { "ItemName", "Price" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    ItemsItemName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ItemsPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => new { x.OrdersId, x.ItemsItemName, x.ItemsPrice });
                    table.ForeignKey(
                        name: "FK_OrderItems_Items_ItemsItemName_ItemsPrice",
                        columns: x => new { x.ItemsItemName, x.ItemsPrice },
                        principalTable: "Items",
                        principalColumns: new[] { "ItemName", "Price" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ItemsItemName_ItemsPrice",
                table: "OrderItems",
                columns: new[] { "ItemsItemName", "ItemsPrice" });
        }
    }
}
