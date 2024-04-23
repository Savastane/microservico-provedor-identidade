using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using systemsecurity.domain;


namespace system.Security.API.Configuration.Entity
{

    public class RoutingMigration : IEntityTypeConfiguration<systemsecurity.domain.Routing> 
    {
        public void Configure(EntityTypeBuilder<systemsecurity.domain.Routing> builder)
        {
            // Nome da tabela
            builder.ToTable("Routing");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").IsRequired().HasDefaultValueSql("NEWSEQUENTIALID()");                        
            builder.Property(r => r.GuidApplication).HasColumnName("GuidApplication").IsRequired();
            builder.Property(r => r.Name).HasColumnName("Name").IsRequired().HasMaxLength(100);
            builder.Property(r => r.Description).HasColumnName("Description").HasMaxLength(1000);
            builder.OwnsOne(routing => routing.RouterCollection, options =>
            {
                options.ToJson();
                options.OwnsMany(colection => colection.Routes);
            });






        }
    }

}


