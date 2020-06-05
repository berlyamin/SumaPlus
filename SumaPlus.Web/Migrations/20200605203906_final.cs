using Microsoft.EntityFrameworkCore.Migrations;

namespace SumaPlus.Web.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pais_Provincia_ProvinciaId",
                table: "Pais");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Pais_PaisId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_PaisId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Pais_ProvinciaId",
                table: "Pais");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "ProvinciaId",
                table: "Pais");

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Suppliers",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PaisesId",
                table: "Suppliers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pais",
                table: "Provincia",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaisesId",
                table: "Provincia",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_PaisesId",
                table: "Suppliers",
                column: "PaisesId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_PaisesId",
                table: "Provincia",
                column: "PaisesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Provincia_Pais_PaisesId",
                table: "Provincia",
                column: "PaisesId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Pais_PaisesId",
                table: "Suppliers",
                column: "PaisesId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provincia_Pais_PaisesId",
                table: "Provincia");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Pais_PaisesId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_PaisesId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Provincia_PaisesId",
                table: "Provincia");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "PaisesId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Provincia");

            migrationBuilder.DropColumn(
                name: "PaisesId",
                table: "Provincia");

            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "Suppliers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinciaId",
                table: "Pais",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_PaisId",
                table: "Suppliers",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Pais_ProvinciaId",
                table: "Pais",
                column: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pais_Provincia_ProvinciaId",
                table: "Pais",
                column: "ProvinciaId",
                principalTable: "Provincia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Pais_PaisId",
                table: "Suppliers",
                column: "PaisId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
