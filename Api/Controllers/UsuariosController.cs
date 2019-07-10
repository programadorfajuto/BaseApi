using System.Collections.Generic;
using BaseApi.Aplicacao.Contratos;
using BaseApi.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace BaseApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IServicoDeUsuario _servicoDeUsuario;

        public UsuariosController(IServicoDeUsuario servicoDeUsuario)
        {
            this._servicoDeUsuario = servicoDeUsuario;
        }

        // GET api/usuarios
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return  this._servicoDeUsuario.ObterTodos();
        }

        // GET api/usuarios/5
        [HttpGet("{id}")]
        public ActionResult<Usuario> Get(int id)
        {
            return this._servicoDeUsuario.Obter(id);
        }

        // POST api/usuarios
        [HttpPost]
        public void Post([FromBody] Usuario usuario)
        {
            this._servicoDeUsuario.Inserir(usuario);
        }

        // PUT api/usuarios/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Usuario usuario)
        {
            this._servicoDeUsuario.Atualizar(id, usuario);
        }

        // DELETE api/usuarios/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this._servicoDeUsuario.Deletar(id);
        }
    }
}
