using system.Security.Entity.Collection;


namespace systemsecurity.domain
{
    public class Application
    {
        public Guid Id { get; set; }        
        public Guid GuidPlataform { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Scope { get; set; }
        public string Status { get; set; } // bloqueado / removido /ativo


    }
}
