using ApiBaseReserva.Data.Mapping;
using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiBaseReserva.Data.Context
{
    public class ApiBaseContext : DbContext
    {
        public ApiBaseContext(DbContextOptions<ApiBaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Empresa>(new EmpresaMap().Configure);
        }
    }
}
