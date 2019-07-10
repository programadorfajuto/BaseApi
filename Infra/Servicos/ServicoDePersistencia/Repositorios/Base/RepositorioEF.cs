using Microsoft.EntityFrameworkCore;
using BaseApi.Dominio.Repositorios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BaseApi.Infra.Servicos.ServicoDePersistencia.Repositorios.Base
{
    public class RepositorioEF<T> : IRepositorio<T> where T : class
    {
        private DbSet<T> _set;

        public RepositorioEF(ContextoEF contexto) => this._set = contexto.Set<T>();

        public T Adicionar(T entidade) => this._set.Add(entidade).Entity;

        public void Adicionar(IEnumerable<T> entidades) => this._set.AddRange(entidades);

        public void Deletar(Expression<Func<T, bool>> filtro) => this._set.RemoveRange(this._set.Where(filtro));

        public void Editar(T entidade) => this._set.Update(entidade);

        public IEnumerable<T> ListarTodos() => this._set.ToList();

        public IEnumerable<T> ListarTodos(Expression<Func<T, bool>> filtro) => this._set.Where(filtro).ToList();

        public T Obter(Expression<Func<T, bool>> filtro) => this._set.FirstOrDefault(filtro);

        public async Task<T> AdicionarAsync(T entidade)
        {
            var retorno = await this._set.AddAsync(entidade);

            return retorno.Entity;
        }

        public Task<IEnumerable<T>> ListarTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ListarTodosAsync(Expression<Func<T, bool>> filtro)
        {
            throw new NotImplementedException();
        }

        public Task<T> ObterAsync(Expression<Func<T, bool>> filtro)
        {
            throw new NotImplementedException();
        }

        public Task AdicionarAsync(IEnumerable<T> entidades)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(Expression<Func<T, bool>> filtro)
        {
            throw new NotImplementedException();
        }

        public Task EditarAsync(T entidade)
        {
            throw new NotImplementedException();
        }
    }
}
