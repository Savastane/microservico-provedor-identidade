using system.Security.API.Domain.Abstracts;
using systemsecurity.domain;

namespace Academico.Domain.Interface
{
    public interface IPlatformRepository
    {
        
        Task<Platform> GetByName(string email);

        IPlatformRepository SetDbSet(dynamic db);

        Task InsertAsync(Platform entity);

    }

}
