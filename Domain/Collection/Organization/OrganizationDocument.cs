namespace system.Security.Entity.Collection
{
    public class OrganizationDocument
    {        
        public Guid Guid  { get; set; }
        public string Slug{ get; set; }
        public List<ApplicationDocument>? Applications { get; set; }


    }
}
