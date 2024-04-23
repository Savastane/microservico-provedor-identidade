using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using system.Security.Entity.Collection;
using systemsecurity.domain;
using System.Reflection.Emit;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Hosting;


namespace system.Security.API.Configuration.Entity
{

    public class UserMigration : IEntityTypeConfiguration<systemsecurity.domain.User> 
    {
        public void Configure(EntityTypeBuilder<systemsecurity.domain.User> builder)
        {

            // Nome da tabela
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.HasIndex(s => new { s.GuidPlataform, s.Email }).IsUnique();
            builder.Property(x => x.Id).HasColumnName("Id").IsRequired().HasDefaultValueSql("NEWSEQUENTIALID()");   
            builder.Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(100);
            builder.Property(x => x.Email).HasColumnName("Email").IsRequired().HasMaxLength(300);
            builder.Property(x => x.Password).HasColumnName("Password").IsRequired().HasMaxLength(500);
            builder.Property(x => x.Photo).HasColumnName("Photo").HasMaxLength(300);
            builder.Property(x => x.Document).HasColumnName("Document").HasMaxLength(30);
            builder.Property(x => x.Status).HasColumnName("Status").HasMaxLength(30);

            builder.OwnsOne(user => user.Allow, options =>
            {
                options.ToJson();
                options.OwnsMany(colection => colection.Resources);
            });

            builder.OwnsOne(user => user.Deny, options =>
            {
                options.ToJson();
                options.OwnsMany(colection => colection.Resources);
            });


            builder.OwnsOne(
            user => user.OrganizationCollection, options =>
            {
               options.ToJson();
               options.OwnsMany(
                                  usercontext => usercontext.Organizations
                                        , options => options.OwnsMany(organizationscontext => organizationscontext.Applications, 
                                          options => options.OwnsMany(applicationcontext => applicationcontext.Roles) )
                              );
            });

            /*
            builder.HasData(
                new User {
                    Id = Guid.NewGuid(),
                    IsBlock = 0,
                    IsRemove = 0,
                    GuidPlataform = Guid.NewGuid(),
                    Name = "Savastane Andrade",
                    Email = "savastane@hotmail.com",
                    Password = "senha123",
                    Status = "Ativo"

                }
            );
            */

        }
    }

}


