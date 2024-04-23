namespace System.API.Application
{
    using Academico.Domain;
    using MediatR;
    
    /// <summary>
    /// Request Login
    /// </summary>
    public class AmbienteRequest : IRequest<AmbienteResponse>
    {
        
        
        public string? IdUsuario { get; set; }
        public string? Usuario { get; set; }
        public string? Email { get; set; }
        public string? IdAplicacao { get; set; }
        public string? IdOrganizacao { get; set; }
        public string? Organizacao { get; set; }
        public string? Role { get; set; }
                


    }




}
