using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceShop.Migrations
{
    /// <inheritdoc />
    public partial class UpDb_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_StyleId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "StyleId",
                table: "Products",
                newName: "ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_StyleId",
                table: "Products",
                newName: "IX_Products_ColorId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "Products",
                newName: "StyleId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                newName: "IX_Products_StyleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_StyleId",
                table: "Products",
                column: "StyleId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
