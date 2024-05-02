namespace System.API.Application
{
    using Academico.Domain;
    using systemsecurity.domain;
    
    
    using MediatR;
    using MediatR.NotificationPublishers;

    /// <summary>
    /// Request Login
    /// </summary>    
    public class InsertPlatformRequest : IRequest<InsertPlatformResponse>
    {          
        public Guid? IdPlatform { get; set; }                
        public string? Nome { get; set; } = String.Empty;
        public string? Descricao { get; set; } = String.Empty;
        public string? Scopo { get; set; } = String.Empty;
        public string? Apelido { get; set; } = String.Empty;
        public List<string>? Apps { get; set; }                       

        public Platform Mapear()
        {

            var plataforma = new Platform()
            {
                Name = Nome,
                Description = Descricao,
                Scope = Scopo,
                Slug = Apelido,
                Status = "Ativo",
                ApplicationCollection = new system.Security.Entity.Collection.ApplicationCollection() 
                { 
                    Applications = new List<system.Security.Entity.Collection.ApplicationDocument>() 
                },
                IsBlock = 0,
                IsRemove =0 
            };         
            
            return plataforma;
        }
    }
}
