


namespace System.API.Application
{
    using MediatR;
    using Academico.Domain;
    

    public class AmbienteResponse : IRequest<AmbienteResponse>
    {

        public string Token { get; set; }

        public AmbienteResponse setToken(string token)
        { 
            this.Token = token;
            return this;
        }


    }

}
