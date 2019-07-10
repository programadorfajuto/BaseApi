using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BaseApi.Infra.Servicos.ServicoDePersistencia.Fabricas
{
    public class FabricaDeContextos : IDesignTimeDbContextFactory<ContextoEF>
    {
        public FabricaDeContextos() { }

        public ContextoEF CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<ContextoEF>();

            //options.UseSqlServer($"Data Source = (LocalDb)\\localhost; initial catalog = ProgramadorFajuto; user id = sa; password = a;");
            options.UseNpgsql($"Host=localhost;Database=BaseApi;Username=postgres;Password=root");

            return new ContextoEF(options.Options);
        }
    }
}
