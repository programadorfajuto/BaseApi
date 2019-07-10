using Microsoft.EntityFrameworkCore;
using BaseApi.Infra.Servicos.ServicoDePersistencia.Mapeamentos.Base;

namespace BaseApi.Infra.Servicos.ServicoDePersistencia.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<T>(this ModelBuilder modelBuilder, MapeamentoEF<T> configuracao) where T : class => configuracao.Map(modelBuilder.Entity<T>());
    }
}
