using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solucion.Migrations
{
    /// <inheritdoc />
    public partial class migra2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TarjetaCreditos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroTarjeta = table.Column<int>(type: "int", nullable: false),
                    LimiteCredito = table.Column<double>(type: "float", nullable: false),
                    SaldoDisponible = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MontoDeuda = table.Column<double>(type: "float", nullable: false),
                    IdClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarjetaCreditos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TarjetaCreditos_Clientes_IdClienteId",
                        column: x => x.IdClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TarjetaCreditos_IdClienteId",
                table: "TarjetaCreditos",
                column: "IdClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TarjetaCreditos");
        }
    }
}
