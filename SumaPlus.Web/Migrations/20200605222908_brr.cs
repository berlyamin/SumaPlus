using Microsoft.EntityFrameworkCore.Migrations;

namespace SumaPlus.Web.Migrations
{
    public partial class brr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Pais_PaisesId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_PaisesId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "PaisesId",
                table: "Suppliers");

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

            migrationBuilder.AddColumn<int>(
                name: "PaisesId",
                table: "Suppliers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_PaisesId",
                table: "Suppliers",
                column: "PaisesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Pais_PaisesId",
                table: "Suppliers",
                column: "PaisesId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
