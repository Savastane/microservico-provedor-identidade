using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using systemsecurity.domain;


namespace system.Security.API.Configuration.Entity
{

    public class RouteMigration : IEntityTypeConfiguration<systemsecurity.domain.Route> 
    {
        public void Configure(EntityTypeBuilder<systemsecurity.domain.Route> builder)
        {
            // Nome da tabela
            builder.ToTable("Route");
            builder.HasKey(x => x.Id);                        
            builder.Property(x => x.Id).HasColumnName("Id").IsRequired().HasDefaultValueSql("NEWSEQUENTIALID()");                        
            builder.Property(r => r.GuidApplication).HasColumnName("GuidApplication").IsRequired();
            builder.Property(r => r.GuidResource).HasColumnName("GuidResource");
            builder.Property(r => r.Title).HasColumnName("Title").IsRequired().HasMaxLength(255);
            builder.Property(r => r.Icon).HasColumnName("Icon").HasMaxLength(255);
            builder.Property(r => r.Description).HasColumnName("Description").HasMaxLength(1000);
            builder.Property(r => r.Type).HasColumnName("Type").HasMaxLength(50);
            builder.Property(r => r.Action).HasColumnName("Action").HasMaxLength(255);
            builder.Property(r => r.Order).HasColumnName("Order");
            builder.Property(r => r.CssClass).HasColumnName("CssClass").HasMaxLength(255);
            builder.Property(x => x.Status).HasColumnName("Status").HasMaxLength(30);
            builder.Property(r => r.IsAccessOnlyRole).HasColumnName("IsAccessOnlyRole").IsRequired();
            builder.Property(r => r.Notification).HasColumnName("Notification");
             

        



        }
    }

}


