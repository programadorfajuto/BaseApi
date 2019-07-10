using BaseApi.Dominio.Repositorios;
using BaseApi.Infra.Contratos;
using BaseApi.Infra.Servicos.ServicoDePersistencia.Fabricas;
using BaseApi.Infra.Servicos.ServicoDePersistencia.Repositorios;
using System;

namespace BaseApi.Infra.Servicos.ServicoDePersistencia
{
    public class UnidadeDeTrabalhoEF : IServicoDePersistencia, IDisposable
    {
        private readonly ContextoEF _contexto;
        private readonly FabricaDeRepositorios _fabricaDeRepositorios;

        public UnidadeDeTrabalhoEF(ContextoEF contexto)
        {
            this._contexto = contexto;
            this._fabricaDeRepositorios = new FabricaDeRepositorios(contexto);
        }

        public IRepositorioDeUsuarios RepositorioDeUsuarios => this._fabricaDeRepositorios.PegarRepositorio<IRepositorioDeUsuarios, RepositorioDeUsuarios>();

        public void Dispose()
        {
            this._contexto.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Persistir() => this._contexto.SaveChanges();
    }
}
