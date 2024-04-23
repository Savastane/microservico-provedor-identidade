


namespace System.API.Application
{
    using MediatR;
    using systemsecurity.domain;

    public class InsertUserResponse : IRequest<InsertUserResponse>
    {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string FotoURL { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public List<CredencialUser> Credenciais { get; set; } = new();

        public bool EmailNaoEncontrado = true;
        public bool PasswordInvalido = true;

        public InsertUserResponse Mapear(User user)
        {
            
            Nome    = user.Name;
            Email   = user.Email;
            Id      = user.Id;

            if (user.OrganizationCollection?.Organizations is not null )
            {
                foreach (var item in user.OrganizationCollection.Organizations)
                {
                    CredencialUser crendencial = new()
                    {
                        IdAplicacao = item.Applications.FirstOrDefault().Guid,
                        IdOrganizacao = item.Guid,
                       // Escola = item.Organizacao,
                        //Roles = item.Roles.Select(s => s.Role).ToList()
                    };

                    this.Credenciais.Add(crendencial);

                }
            }
            
            FotoURL = "http://www.sava.com/foto.jpg";


            return this;

        }


        public InsertUserResponse()
        {
            
        }

        public InsertUserResponse(string nome, string email, string token, List<string> roles, bool passwordInvalido)
        {
            Nome = nome;
            Email = email;
            Token = token;
            
            EmailNaoEncontrado = false;
            PasswordInvalido = passwordInvalido;

        }

        


    }


}
