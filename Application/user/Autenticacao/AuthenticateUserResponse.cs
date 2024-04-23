


namespace System.API.Application
{
    using MediatR;
    using systemsecurity.domain;

    public class AuthenticateUserResponse : IRequest<AuthenticateUserResponse>
    {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string FotoURL { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public List<CredencialUser> Credenciais { get; set; } = new();

        public bool EmailNaoEncontrado = true;
        public bool PasswordInvalido = true;

        public AuthenticateUserResponse Mapear(User user, string token)
        {

            Token   = token;
            Nome    = user.Name;
            Email   = user.Email;
            Id      = user.Id;

            if (user.OrganizationCollection?.Organizations is not null )
            {
                foreach (var item in user.OrganizationCollection.Organizations)
                {
                    //CredencialUser crendencial = new()
                    //{
                    //    Id = item.Id,
                    //    App = item.App,
                    //    Escola = item.IdEscola,
                    //    Roles = item.Roles
                    //};

                    //this.Credenciais.Add(crendencial);

                }
            }
            
            FotoURL = "http://www.sava.com/foto.jpg";


            return this;

        }


        public AuthenticateUserResponse()
        {
            
        }

        public AuthenticateUserResponse(string nome, string email, string token, List<string> roles, bool passwordInvalido)
        {
            Nome = nome;
            Email = email;
            Token = token;
            
            EmailNaoEncontrado = false;
            PasswordInvalido = passwordInvalido;

        }


    }


    public class CredencialUser {
        public Guid IdAplicacao { get; set; }
        public Guid IdOrganizacao{ get; set; }
        public string Escola { get; set; }        
        public List<string> Roles { get; set; }
    } 
}
