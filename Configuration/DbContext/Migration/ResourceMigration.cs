using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using systemsecurity.domain;


namespace system.Security.API.Configuration.Entity
{

    public class ResourceMigration : IEntityTypeConfiguration<systemsecurity.domain.Resource> 
    {
        public void Configure(EntityTypeBuilder<systemsecurity.domain.Resource> builder)
        {
            // Nome da tabela
            builder.ToTable("Resource");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").IsRequired().HasDefaultValueSql("NEWSEQUENTIALID()");                        
            builder.Property(r => r.GuidApplication).HasColumnName("GuidApplication").IsRequired();
            builder.Property(r => r.Name).HasColumnName("Name").IsRequired().HasMaxLength(100);
            builder.Property(r => r.Description).HasColumnName("Description").HasMaxLength(1000);
            builder.Property(r => r.Type).HasColumnName("Type").HasMaxLength(50);
            builder.Property(r => r.Order).HasColumnName("Order");
            builder.Property(r => r.Notification).HasColumnName("Notification");
             

        



        }
    }

}


