using Microsoft.EntityFrameworkCore.Migrations;

namespace SumaPlus.Web.Migrations
{
    public partial class tes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Suppliers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Pais",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pais_SupplierId",
                table: "Pais",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pais_Suppliers_SupplierId",
                table: "Pais",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pais_Suppliers_SupplierId",
                table: "Pais");

            migrationBuilder.DropIndex(
                name: "IX_Pais_SupplierId",
                table: "Pais");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Pais");
        }
    }
}
