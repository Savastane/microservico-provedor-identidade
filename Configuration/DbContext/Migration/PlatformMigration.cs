using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using systemsecurity.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity;
using system.Security.Entity.Collection;


namespace system.Security.API.Configuration.Entity
{

    public class PlatformMigration : IEntityTypeConfiguration<Platform> 
    {
        public void Configure(EntityTypeBuilder<systemsecurity.domain.Platform> builder)
        {
            
            builder.ToTable("Platform");

            builder.HasKey(x => x.Id);            
            builder.Property(x => x.Id).HasColumnName("Id").IsRequired().HasDefaultValueSql("NEWSEQUENTIALID()");
            builder.Property(x => x.Slug).HasColumnName("Slug").IsRequired().HasMaxLength(10);
            builder.Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(100);
            builder.Property(x => x.Scope).HasColumnName("Scope").HasMaxLength(1000);
            builder.Property(x => x.Description).HasColumnName("Description").HasMaxLength(1000);
            builder.Property(x => x.Status).HasColumnName("Status").HasMaxLength(30);

            builder.OwnsOne( plataform => plataform.ApplicationCollection, options =>
            {
                options.ToJson();
                options.OwnsMany(colection => colection.Applications,
                                           options => options.OwnsMany(applicationcontext => applicationcontext.Roles));

            });

            builder.HasData(
                new systemsecurity.domain.Platform
                {
                    Id = Guid.NewGuid(),
                    Slug = "",
                    Name = "Level",
                    Scope = "Marketing Place Servicos (xell) )",
                    Description = "Marketing Place Servicos",
                    IsBlock = 0,
                    IsRemove = 0,
                    ApplicationCollection = new ApplicationCollection() {
                        Applications = new List<ApplicationDocument>() { 
                          new ApplicationDocument(){
                              Guid = Guid.NewGuid(),
                              Slug ="",
                              Roles = new() {                                    
                              }
                          }
                        }
                    },  
                    Status = "Ativo"
                }
           ); 

        }
    }

}



