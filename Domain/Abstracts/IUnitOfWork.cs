using Academico.Domain.Interface;

namespace system.Security.API.Domain.Abstracts
{
    public interface IUnitOfWork
    {        
        Task<bool>  CommitAsync();        
        IPlatformRepository GetPlatformRepository();
        IApplicationRepository GetApplicationRepository();
        IUserRepository GetUserRepository();
    }
}
