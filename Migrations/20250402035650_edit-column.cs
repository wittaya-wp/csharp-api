using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class Editcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Stocks_StocksId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_StocksId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "StocksId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Margetcap",
                table: "Stocks",
                newName: "MarketCap");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_StockId",
                table: "Comments",
                column: "StockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Stocks_StockId",
                table: "Comments",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Stocks_StockId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_StockId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "MarketCap",
                table: "Stocks",
                newName: "Margetcap");

            migrationBuilder.AddColumn<int>(
                name: "StocksId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_StocksId",
                table: "Comments",
                column: "StocksId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Stocks_StocksId",
                table: "Comments",
                column: "StocksId",
                principalTable: "Stocks",
                principalColumn: "Id");
        }
    }
}
