using system.Security.API.Domain.Abstracts;
using systemsecurity.domain;

namespace Academico.Domain.Interface
{
    public interface IPlatformRepository
    {
        
        Task<Platform> GetByName(string nome);

        IPlatformRepository SetDbSet(dynamic db);

        Task InsertAsync(Platform entity);

    }

}
