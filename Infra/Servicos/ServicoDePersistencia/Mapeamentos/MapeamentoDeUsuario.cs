using BaseApi.Dominio.Entidades;
using BaseApi.Infra.Servicos.ServicoDePersistencia.Mapeamentos.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BaseApi.Infra.Servicos.ServicoDePersistencia.Mapeamentos
{
    public class MapeamentoDeUsuario : MapeamentoEF<Usuario>
    {
        public override void Map(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(p => p.Id);
        }
    }
}
