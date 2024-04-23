using Academico.Domain;
using Academico.Domain.Interface;

using Academico.System.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using systemsecurity.domain;

namespace Academico.Repository
{
    public class ApplicationRepository : IApplicationRepository
    {
        private SystemContext systemContext;

        public ApplicationRepository(SystemContext db) {
            systemContext = db;

        }

        public async Task<Role> AddRole(Role role)
        {
            //&& r.Nome == role.Nome
            var roledb =  systemContext.Role.Where(r => r.Id.Equals(role.GuidApplication) ).FirstOrDefault();

            if (roledb is null)
                systemContext.Role.Add(role);
            else
                systemContext.Role.Update(role);


            systemContext.SaveChanges();
            await systemContext.SaveChangesAsync();
            return role;
        }
    }
}
