using Academico.Domain.Interface;
using systemsecurity.domain;

namespace system.Security.API.Domain.Abstracts
{
    public abstract class Entity
    {
        public Guid Id { get;  set; }
        public int IsBlock { get; set; }
        public int IsRemove { get; set; }        

    }


}
