using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FakeStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenamedProduDbSettoProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Produ_ProductId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produ",
                table: "Produ");

            migrationBuilder.RenameTable(
                name: "Produ",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Products_ProductId",
                table: "Items",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Products_ProductId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Produ");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produ",
                table: "Produ",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Produ_ProductId",
                table: "Items",
                column: "ProductId",
                principalTable: "Produ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
