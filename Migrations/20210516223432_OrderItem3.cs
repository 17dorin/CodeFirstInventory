using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice2.Migrations
{
    public partial class OrderItem3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Orders_ItemName_ItemPrice",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ItemName1_ItemPrice",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ItemName1",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderItems",
                newName: "OrdersId");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "OrderItems",
                newName: "ItemsPrice");

            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "OrderItems",
                newName: "ItemsItemName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                columns: new[] { "OrdersId", "ItemsItemName", "ItemsPrice" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ItemsItemName_ItemsPrice",
                table: "OrderItems",
                columns: new[] { "ItemsItemName", "ItemsPrice" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Items_ItemsItemName_ItemsPrice",
                table: "OrderItems",
                columns: new[] { "ItemsItemName", "ItemsPrice" },
                principalTable: "Items",
                principalColumns: new[] { "ItemName", "Price" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrdersId",
                table: "OrderItems",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Items_ItemsItemName_ItemsPrice",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrdersId",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ItemsItemName_ItemsPrice",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "ItemsPrice",
                table: "OrderItems",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "ItemsItemName",
                table: "OrderItems",
                newName: "ItemName");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "OrderItems",
                newName: "OrderId");

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ItemPrice",
                table: "Orders",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemName1",
                table: "OrderItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ItemPrice",
                table: "OrderItems",
                type: "real",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                columns: new[] { "ItemName", "Price", "OrderId" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ItemName_ItemPrice",
                table: "Orders",
                columns: new[] { "ItemName", "ItemPrice" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ItemName1_ItemPrice",
                table: "OrderItems",
                columns: new[] { "ItemName1", "ItemPrice" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

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
    }
}
