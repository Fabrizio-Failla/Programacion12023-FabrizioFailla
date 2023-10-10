using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solucion.Migrations
{
    /// <inheritdoc />
    public partial class migra3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TarjetaCreditos_Clientes_IdClienteId",
                table: "TarjetaCreditos");

            migrationBuilder.RenameColumn(
                name: "IdClienteId",
                table: "TarjetaCreditos",
                newName: "IdCuentaBancariaId");

            migrationBuilder.RenameIndex(
                name: "IX_TarjetaCreditos_IdClienteId",
                table: "TarjetaCreditos",
                newName: "IX_TarjetaCreditos_IdCuentaBancariaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TarjetaCreditos_CuentaBancarias_IdCuentaBancariaId",
                table: "TarjetaCreditos",
                column: "IdCuentaBancariaId",
                principalTable: "CuentaBancarias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TarjetaCreditos_CuentaBancarias_IdCuentaBancariaId",
                table: "TarjetaCreditos");

            migrationBuilder.RenameColumn(
                name: "IdCuentaBancariaId",
                table: "TarjetaCreditos",
                newName: "IdClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_TarjetaCreditos_IdCuentaBancariaId",
                table: "TarjetaCreditos",
                newName: "IX_TarjetaCreditos_IdClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_TarjetaCreditos_Clientes_IdClienteId",
                table: "TarjetaCreditos",
                column: "IdClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
