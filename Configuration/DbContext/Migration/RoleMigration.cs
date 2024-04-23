using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using system.Security.Entity.Collection;
using systemsecurity.domain;


namespace system.Security.API.Configuration.Entity
{

    public class RoleMigration : IEntityTypeConfiguration<systemsecurity.domain.Role> 
    {
        public void Configure(EntityTypeBuilder<systemsecurity.domain.Role> builder)
        {
            // Nome da tabela
            builder.ToTable("Role");

            builder.HasKey(x => x.Id);            
            
            builder.Property(x => x.Id).HasColumnName("Id").IsRequired().HasDefaultValueSql("NEWSEQUENTIALID()");                        
            builder.Property(r => r.GuidApplication).HasColumnName("GuidApplication").IsRequired();

            builder.OwnsOne(plataform => plataform.RouteCollection, options =>
            {
                options.ToJson();
                options.OwnsMany(colection => colection.Routes);

            });



        }
    }

}


