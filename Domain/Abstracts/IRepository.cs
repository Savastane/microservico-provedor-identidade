using Academico.Domain.Interface;
using Academico.Repository;
using Academico.System.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using systemsecurity.domain;

namespace system.Security.API.Domain.Abstracts
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetFilterAsync(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> GetByGuidAsync(string guid);
        Task InsertAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task BlockAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
        DbSet<TEntity> GetSet();
        IRepository<TEntity> SetDbSet(dynamic db);
        

    }


}
