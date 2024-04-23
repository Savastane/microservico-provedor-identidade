using Academico.Domain.Interface;

namespace system.Security.API.Domain.Abstracts
{
    public interface IUnitOfWork
    {        
        Task<bool>  CommitAsync();
        IUserRepository GetUserRepository();

    }
}
