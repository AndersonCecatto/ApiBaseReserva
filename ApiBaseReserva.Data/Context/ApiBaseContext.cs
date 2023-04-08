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
            modelBuilder.Entity<Endereco>(new EnderecoMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Estado>(new EstadoMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Funcionario>(new FuncionarioMap().Configure);
            modelBuilder.Entity<ConfiguracoesEmpresa>(new ConfiguracoesEmpresaMap().Configure);
            modelBuilder.Entity<Mesa>(new MesaMap().Configure);
            modelBuilder.Entity<ConfiguracoesReserva>(new ConfiguracoesReservaMap().Configure);
            modelBuilder.Entity<Reserva>(new ReservaMap().Configure);
            modelBuilder.Entity<EmpresaAdicional>(new EmpresaAdicionalMap().Configure);
            modelBuilder.Entity<Periodo>(new PeriodoMap().Configure);
            modelBuilder.Entity<Servico>(new ServicoMap().Configure);
            modelBuilder.Entity<Avaliacao>(new AvaliacaoMap().Configure);
        }
    }
}
