using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice2.Migrations
{
    public partial class OrderItem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_ItemName_ItemPrice",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Items_ItemName1_ItemPrice",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "OrderItem",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_ItemName1_ItemPrice",
                table: "OrderItems",
                newName: "IX_OrderItems_ItemName1_ItemPrice");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ItemName_ItemPrice",
                table: "Orders",
                newName: "IX_Orders_ItemName_ItemPrice");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                columns: new[] { "ItemName", "Price", "OrderId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Items_ItemName1_ItemPrice",
                table: "OrderItems",
                columns: new[] { "ItemName1", "ItemPrice" },
                principalTable: "Items",
                principalColumns: new[] { "ItemName", "Price" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Items_ItemName_ItemPrice",
                table: "Orders",
                columns: new[] { "ItemName", "ItemPrice" },
                principalTable: "Items",
                principalColumns: new[] { "ItemName", "Price" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Items_ItemName1_ItemPrice",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Items_ItemName_ItemPrice",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItem");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ItemName_ItemPrice",
                table: "Order",
                newName: "IX_Order_ItemName_ItemPrice");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_ItemName1_ItemPrice",
                table: "OrderItem",
                newName: "IX_OrderItem_ItemName1_ItemPrice");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem",
                columns: new[] { "ItemName", "Price", "OrderId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_ItemName_ItemPrice",
                table: "Order",
                columns: new[] { "ItemName", "ItemPrice" },
                principalTable: "Items",
                principalColumns: new[] { "ItemName", "Price" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Items_ItemName1_ItemPrice",
                table: "OrderItem",
                columns: new[] { "ItemName1", "ItemPrice" },
                principalTable: "Items",
                principalColumns: new[] { "ItemName", "Price" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
