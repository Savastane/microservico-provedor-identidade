using Academico.Repository;
using Microsoft.EntityFrameworkCore;
using system.Security.API.Domain.Abstracts;
using System.Linq.Expressions;
using systemsecurity.domain;

namespace Academico.Domain.Interface
{

    public interface IUserRepository
    {
        
        Task<User> Autenticar(User usuario);
        Task<User> Autenticar(string email, string senha, string aplicativo);
        Task<User> TocarSenhar(User usuario);        
        Task<User> GetByEmail(string email);
        
        Task<User> GetByGuidAsync(string guid);
        Task UpdateAsync(User entity);
        Task InsertAsync(User entity);
        Task<IEnumerable<User>> GetAllAsync();
        Task<IEnumerable<User>> GetFilterAsync(Expression<Func<User, bool>> filter = null);
        Task BlockAsync(User entity);
        IUserRepository SetDbSet(dynamic db);





    }

}
