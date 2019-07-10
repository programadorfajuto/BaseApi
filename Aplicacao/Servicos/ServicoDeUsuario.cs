using BaseApi.Aplicacao.Contratos;
using BaseApi.Dominio.Entidades;
using BaseApi.Infra.Contratos;
using System.Collections.Generic;

namespace BaseApi.Aplicacao.Servicos
{
    public class ServicoDeUsuario : IServicoDeUsuario
    {
        private readonly IServicoDePersistencia _servicoDePersistencia;

        public ServicoDeUsuario(IServicoDePersistencia servicoDePersistencia)
        {
            this._servicoDePersistencia = servicoDePersistencia;
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return this._servicoDePersistencia.RepositorioDeUsuarios.ListarTodos();
        }

        public Usuario Obter(int id)
        {
            return this._servicoDePersistencia.RepositorioDeUsuarios.Obter(p => p.Id == id);
        }

        public void Inserir(Usuario usuario)
        {
            this._servicoDePersistencia.RepositorioDeUsuarios.Adicionar(usuario);
            this._servicoDePersistencia.Persistir();
        }

        public void Atualizar(int id, Usuario usuario)
        {
            this._servicoDePersistencia.RepositorioDeUsuarios.Editar(usuario);
            this._servicoDePersistencia.Persistir();
        }

        public void Deletar(int id)
        {
            this._servicoDePersistencia.RepositorioDeUsuarios.Deletar(u => u.Id == id);
            this._servicoDePersistencia.Persistir();
        }
    }
}
