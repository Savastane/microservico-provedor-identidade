using Academico.Domain;
using Academico.Domain.Interface;

using Academico.System.Configuration;
using Consul.Filtering;
using Microsoft.EntityFrameworkCore;
using system.Security.API.Domain.Abstracts;
using System;
using System.Linq.Expressions;
using systemsecurity.domain;

namespace Academico.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        
    
        private  DbSet<TEntity> _dbSet;              

   

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var query = _dbSet.AsQueryable();
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetFilterAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            var query = _dbSet.AsQueryable();

            if (filter != null)
                query = query
                    .Where(filter)
                    .AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<TEntity> GetByGuidAsync(string guid)
        {
            return await _dbSet.FindAsync(guid);
        }

        public async Task  InsertAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            
            
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public async Task RemoveAsync(TEntity entity)
        {
            _dbSet.Remove(entity);            
        }

        public async Task BlockAsync(TEntity entity)
        {
            //*
            // mapear  block
            
            _dbSet.Update(entity);
        }

        public DbSet<TEntity> GetSet()
        {
            return _dbSet;
        }

        IRepository<TEntity> IRepository<TEntity>.SetDbSet(dynamic db)
        {
            _dbSet = db.Set<TEntity>();
            return this;
        }


        //public async Task<User> Atualizar(User usuario)
        //{
        //    systemContext.User.Update(usuario);
        //    systemContext.SaveChanges();
        //    await systemContext.SaveChangesAsync();

        //    return usuario;
        //}

        //public Task<User> Autenticar(User usuario)
        //{         
        //    return systemContext.User.Where(u => u.Email == usuario.Email&& u.Password == usuario.Password).FirstOrDefaultAsync();
        //}

        //public Task<User?> Autenticar(string email, string senha, string aplicativo)
        //{
        //    return systemContext.User.Where(u=> u.Email == email && u.Password == senha).FirstOrDefaultAsync();

        //}

        //public Task<User> GetByEmail(string email)
        //{
        //    return systemContext.User.Where(u => u.Email.Equals(email)).FirstOrDefaultAsync();
        //}

        //public Task<User> GetById(string Id)
        //{
        //    return systemContext.User.Where(u => u.Id.Equals(new Guid(Id))).FirstOrDefaultAsync();
        //}

        //public Task<List<User>> GetUsuarios()
        //{
        //    return systemContext.User.ToListAsync();
        //}

        //public async Task<User> Inserir(User usuario)
        //{
        //    systemContext.User.Add(usuario);
        //    systemContext.SaveChanges();

        //    await systemContext.SaveChangesAsync();

        //    return usuario;
        //}

        //public Task<User> TocarSenhar(User usuario)
        //{
        //    throw new NotImplementedException();
        //}







    }
}
