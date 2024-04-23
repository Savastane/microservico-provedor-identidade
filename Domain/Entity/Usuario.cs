using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using system.Security.API.Domain.Json.Usuario.Acesso;

namespace systemsecurity.domain
{

    public class Usuario
    {
        
        public Guid Id { get; set; }        
        public string Nome { get; set; }        
        public string Email { get; set; }
        public string Senha { get; set; }
        public string? FotoURL { get; set; }
        public string? Documento { get; set; }
        public string? OrigemClientes{ get; set; }
        public Acesso? Acesso { get; set; }
        // public Credencial? Credenciais { get; set; }

        // listra de guid de acoes, que nao tem acesso 
        public List<string> NegarAcesso{ get; set; } = new();

        // listra de guid com aceos, que nao tem acesso 
        public List<string> PermitirAcesso { get; set; } = new();

        public int Bloqueado { get; set; }
        public int Exclusao { get; set; }

        public Usuario MapAutenticacao(  string email, string password)
        {            
            this.Email = email;
            this.Senha = password;
            return this;       
        }

    }
}
