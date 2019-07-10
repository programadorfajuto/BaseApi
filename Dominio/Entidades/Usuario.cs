using BaseApi.Dominio.Entidades.Base;

namespace BaseApi.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}