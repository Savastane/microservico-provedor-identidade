using systemsecurity.domain;

namespace Academico.Domain.Interface
{
    public interface IApplicationRepository
    {
        Task<Role> AddRole(Role role);


    }


}
