namespace system.Security.Entity.Collection
{
    public class ApplicationDocument{        
        public Guid Guid  { get; set; }
        public string Slug{ get; set; }
        public List<RoleDocument>? Roles { get; set; }

    }
}
