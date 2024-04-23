namespace System.API.Application
{
    using systemsecurity.domain;
    using MediatR;
    
    /// <summary>
    /// Request Login
    /// </summary>
    public class AuthenticateUserRequest : IRequest<AuthenticateUserResponse>
    {
        
        /// <summary>
        /// Id da Empresa        
        /// </summary>
        /// <exemple>2121212121212121</exemple>
        public string? Id { get; set; }
        /// <summary>
        /// Id da Empresa        
        /// </summary>
        /// <exemplo>savastane@gmail.com</exemplo>
        public string? Email { get; set; }
        
        /// <summary>
        /// Id da Empresa        
        /// </summary>
        /// <exemplo>12345</exemplo>
        public string? Password { get; set; }

        
        public User Mapear()
        {
            var usuario = new User()
            {
                Email = this.Email,
                Password = this.Password,
            };

            return usuario;

        }


    }




}
