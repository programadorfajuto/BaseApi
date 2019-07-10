using BaseApi.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using BaseApi.Infra.Servicos.ServicoDePersistencia.Mapeamentos;
using BaseApi.Infra.Servicos.ServicoDePersistencia.Extensions;

namespace BaseApi.Infra.Servicos.ServicoDePersistencia
{
    public class ContextoEF : DbContext
    {
        public ContextoEF(DbContextOptions<ContextoEF> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.AddConfiguration(new MapeamentoDeUsuario());
        }
    }
}
