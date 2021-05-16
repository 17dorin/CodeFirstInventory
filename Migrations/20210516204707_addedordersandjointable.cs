using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice2.Migrations
{
    public partial class addedordersandjointable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ItemPrice = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Items_ItemName_ItemPrice",
                        columns: x => new { x.ItemName, x.ItemPrice },
                        principalTable: "Items",
                        principalColumns: new[] { "ItemName", "Price" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    ItemName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ItemName1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ItemPrice = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => new { x.ItemName, x.Price, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderItem_Items_ItemName1_ItemPrice",
                        columns: x => new { x.ItemName1, x.ItemPrice },
                        principalTable: "Items",
                        principalColumns: new[] { "ItemName", "Price" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_ItemName_ItemPrice",
                table: "Order",
                columns: new[] { "ItemName", "ItemPrice" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ItemName1_ItemPrice",
                table: "OrderItem",
                columns: new[] { "ItemName1", "ItemPrice" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
