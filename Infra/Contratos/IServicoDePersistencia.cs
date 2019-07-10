using BaseApi.Dominio.Repositorios;

namespace BaseApi.Infra.Contratos
{
    public interface IServicoDePersistencia
    {
        void Persistir();

        IRepositorioDeUsuarios RepositorioDeUsuarios { get; }
    }
}
