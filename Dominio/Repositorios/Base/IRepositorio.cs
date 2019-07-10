using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BaseApi.Dominio.Repositorios.Base
{
    public interface IRepositorio<T> where T : class
    {
        IEnumerable<T> ListarTodos();
        IEnumerable<T> ListarTodos(Expression<Func<T, bool>> filtro);
        T Obter(Expression<Func<T, bool>> filtro);
        T Adicionar(T entidade);
        void Adicionar(IEnumerable<T> entidades);
        void Deletar(Expression<Func<T, bool>> filtro);
        void Editar(T entidade);
        Task<IEnumerable<T>> ListarTodosAsync();
        Task<IEnumerable<T>> ListarTodosAsync(Expression<Func<T, bool>> filtro);
        Task<T> ObterAsync(Expression<Func<T, bool>> filtro);
        Task<T> AdicionarAsync(T entidade);
        Task AdicionarAsync(IEnumerable<T> entidades);
        Task DeletarAsync(Expression<Func<T, bool>> filtro);
        Task EditarAsync(T entidade);
    }
}
