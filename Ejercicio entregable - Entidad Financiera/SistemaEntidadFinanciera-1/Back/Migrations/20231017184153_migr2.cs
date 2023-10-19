using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class migr2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TarjetadeCreditos_CuentaBancarias_PropietarioId",
                table: "TarjetadeCreditos");

            migrationBuilder.AddForeignKey(
                name: "FK_TarjetadeCreditos_Clientes_PropietarioId",
                table: "TarjetadeCreditos",
                column: "PropietarioId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TarjetadeCreditos_Clientes_PropietarioId",
                table: "TarjetadeCreditos");

            migrationBuilder.AddForeignKey(
                name: "FK_TarjetadeCreditos_CuentaBancarias_PropietarioId",
                table: "TarjetadeCreditos",
                column: "PropietarioId",
                principalTable: "CuentaBancarias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
