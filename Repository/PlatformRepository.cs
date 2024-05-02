using Academico.Domain;
using Academico.Domain.Interface;

using Academico.System.Configuration;
using Microsoft.EntityFrameworkCore;
using system.Security.API.Domain.Abstracts;
using systemsecurity.domain;

namespace Academico.Repository
{
    public class PlatformRepository : IPlatformRepository
    {
        private readonly IRepository<Platform> _repository;

        public PlatformRepository(IRepository<Platform> repository)
        {
            _repository = repository;
        }

        public Task<Platform> Block(Platform entity)
        {
            throw new NotImplementedException();
        }

        public Task<Platform> Delete(Platform entity)
        {
            throw new NotImplementedException();
        }

        public async Task InsertAsync(Platform entity)
        {
            await _repository.InsertAsync(entity);
        }


        public Task<IEnumerable<Platform>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Platform> GetByGuid(string guid)
        {
            return _repository.GetByGuidAsync(guid);
        }

        public Task<Platform> GetByName(string nome)
        {
            return _repository.GetSet().Where(u => u.Name.Equals(nome)).FirstOrDefaultAsync();
        }

        public Task<List<Platform>> GetPlataforms()
        {
            throw new NotImplementedException();
        }

        public Task<Platform> Insert(Platform platform)
        {
            throw new NotImplementedException();
        }

        public Task<Platform> Update(Platform platform)
        {
            throw new NotImplementedException();
        }

        IPlatformRepository IPlatformRepository.SetDbSet(dynamic db)
        {
            _repository.SetDbSet(db);
            return this;

        }

    }
}
