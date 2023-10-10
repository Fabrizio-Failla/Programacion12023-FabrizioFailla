using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solucion.Migrations
{
    /// <inheritdoc />
    public partial class migra1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuentaBancarias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroCuenta = table.Column<int>(type: "int", nullable: false),
                    Saldo = table.Column<double>(type: "float", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaBancarias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuentaBancarias_Clientes_IdClienteId",
                        column: x => x.IdClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CuentaBancarias_IdClienteId",
                table: "CuentaBancarias",
                column: "IdClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuentaBancarias");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
