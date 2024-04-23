using Academico.Domain;
using Academico.Domain.Interface;

using Academico.System.Configuration;
using Microsoft.EntityFrameworkCore;
using system.Security.API.Domain.Abstracts;
using System;
using System.Linq.Expressions;
using systemsecurity.domain;

namespace Academico.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly IRepository<User> _repository;
        
        public UserRepository(IRepository<User> repository) {
            _repository = repository;                           
        }

        public async Task UpdateAsync(User entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task InsertAsync(User entity)
        {
            await _repository.InsertAsync(entity);
        }


        public Task<User> Autenticar(User usuario)
        {            

            
            return _repository.GetSet().Where(u => u.Email == usuario.Email && u.Password == usuario.Password).FirstOrDefaultAsync(); ;
        }

        public Task<User?> Autenticar(string email, string senha, string aplicativo)
        {
            return _repository.GetSet().Where(u=> u.Email == email && u.Password == senha).FirstOrDefaultAsync();
            
        }

        public Task<User> GetByEmail(string email)
        {            
            return _repository.GetSet().Where(u => u.Email.Equals(email)).FirstOrDefaultAsync();
        }

        public  Task<User> GetByGuidAsync(string guid)
        {
           return _repository.GetByGuidAsync(guid);
        }
               

        public Task<User> TocarSenhar(User usuario)
        {
            throw new NotImplementedException();
        }


        public Task<IEnumerable<User>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<IEnumerable<User>> GetFilterAsync(Expression<Func<User, bool>> filter = null)
        {
            return _repository.GetFilterAsync(filter);
        }

        public async Task BlockAsync(User entity)
        {
            await _repository.BlockAsync(entity);
        }

        

        IUserRepository IUserRepository.SetDbSet(dynamic db)
        {
            _repository.SetDbSet(db);
            return this;
            
        }
    }
}
