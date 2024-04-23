



using system.Security.API.Domain.Json.Usuario.Acesso;
using systemsecurity.domain;

namespace Academico.Domain.Interface
{
    public interface ISystemRepository
    {
        Task<Usuario> CriarUsuario(Usuario usuario);

        Task<Usuario> GetAmbiente(Credencial usuario);


    }


}
