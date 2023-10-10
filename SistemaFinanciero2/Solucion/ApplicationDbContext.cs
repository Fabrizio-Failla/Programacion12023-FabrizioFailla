using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaBancaria> CuentaBancarias { get; set; }
        public DbSet<TarjetaCredito> TarjetaCreditos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =.; database =PruebaLogica; trusted_connection = true; Encrypt = False");
        }
    }
}
