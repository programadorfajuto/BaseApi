using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BaseApi.Infra.Servicos.ServicoDePersistencia.Mapeamentos.Base
{
    public abstract class MapeamentoEF<T> where T : class
    {
        public abstract void Map(EntityTypeBuilder<T> builder);
    }
}
