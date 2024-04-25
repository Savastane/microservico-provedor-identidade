


namespace System.API.Application
{
    using MediatR;
    using systemsecurity.domain;

    public class InsertPlatformResponse : IRequest<InsertPlatformRequest>
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Apelido { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;        
        public string Scopo { get; set; } = string.Empty;
        

        public InsertPlatformResponse Mapear(Platform  plataform)
        {
            Id        = plataform.Id;
            Nome      = plataform.Name;
            Apelido   = plataform.Slug;
            Id        = plataform.Id;
            Descricao = plataform.Description;
            Scopo     = plataform.Scope;
            return this;

        }


    }


}
