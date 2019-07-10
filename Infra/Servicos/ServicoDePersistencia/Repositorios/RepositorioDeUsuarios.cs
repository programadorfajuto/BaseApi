using BaseApi.Dominio.Entidades;
using BaseApi.Dominio.Repositorios;
using BaseApi.Infra.Servicos.ServicoDePersistencia.Repositorios.Base;

namespace BaseApi.Infra.Servicos.ServicoDePersistencia.Repositorios
{
    public class RepositorioDeUsuarios : RepositorioEF<Usuario>, IRepositorioDeUsuarios
    {
        public RepositorioDeUsuarios(ContextoEF contexto) : base(contexto) { }
    }
}
