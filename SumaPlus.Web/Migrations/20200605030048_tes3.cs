using Microsoft.EntityFrameworkCore.Migrations;

namespace SumaPlus.Web.Migrations
{
    public partial class tes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "Suppliers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_PaisId",
                table: "Suppliers",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Pais_PaisId",
                table: "Suppliers",
                column: "PaisId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Pais_PaisId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_PaisId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Suppliers");

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Suppliers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Pais",
                type: "int",
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
    }
}
