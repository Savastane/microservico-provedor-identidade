using Academico.Domain;
using Academico.Domain.Interface;

using Academico.System.Configuration;
using Microsoft.EntityFrameworkCore;
using systemsecurity.domain;

namespace Academico.Repository
{
    public class PlatformRepository : IPlatformRepository
    {
        private SystemContext systemContext;

        public PlatformRepository(SystemContext db) {
            systemContext = db;

        }

        public Task<Platform> Block(Platform entity)
        {
            throw new NotImplementedException();
        }

        public Task<Platform> Delete(Platform entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Platform>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Platform> GetByGuid(string guid)
        {
            throw new NotImplementedException();
        }

        public Task<Platform> GetByName(string email)
        {
            throw new NotImplementedException();
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
    }
}
