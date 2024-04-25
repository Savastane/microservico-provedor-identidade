using Academico.Domain.Interface;
using Academico.Repository;
using Academico.System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query.Internal;
using system.Security.API.Domain.Abstracts;
using systemsecurity.domain;

namespace system.Security.API.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SystemContext _context;
        private  IUserRepository _userRepository;
        private  IPlatformRepository _platformRepository;

        public UnitOfWork(SystemContext context)
        {            
            _context = context;         
        }


        public async Task<bool> CommitAsync()
        {           
           return await _context.SaveChangesAsync() > 0;
        }

        public Task RollbackAsync()
        {
            throw new NotImplementedException();
        }

        public IUserRepository GetUserRepository()
        {
            if (_userRepository is null) {
                _userRepository = new UserRepository(new Repository<User>());
                _userRepository.SetDbSet(_context);
            }

            return _userRepository;
        }

        public IPlatformRepository GetPlatformRepository()
        {
            if (_platformRepository is null)
            {
                _platformRepository = new PlatformRepository(new Repository<Platform>());
                _platformRepository.SetDbSet(_context);
            }

            return _platformRepository;
        }


    }
}

