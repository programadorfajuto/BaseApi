using BaseApi.Dominio.Entidades;
using System.Collections.Generic;

namespace BaseApi.Aplicacao.Contratos
{
    public interface IServicoDeUsuario
    {
        IEnumerable<Usuario> ObterTodos();
        Usuario Obter(int id);
        void Inserir(Usuario usuario);
        void Atualizar(int id, Usuario usuario);
        void Deletar(int id);
    }
}
