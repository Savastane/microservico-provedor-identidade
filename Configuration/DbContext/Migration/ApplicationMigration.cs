using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using systemsecurity.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace system.Security.API.Configuration.Entity
{

    public class ApplicationMigration : IEntityTypeConfiguration<systemsecurity.domain.Application>
    {
        public void Configure(EntityTypeBuilder<systemsecurity.domain.Application> builder)
        {
            // Nome da tabela
            builder.ToTable("Application");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").IsRequired().HasDefaultValueSql("NEWSEQUENTIALID()"); 
            builder.Property(x => x.GuidPlataform).HasColumnName("GuidPlataform").IsRequired();
            builder.Property(x => x.Name).HasColumnName("Slug").IsRequired().HasMaxLength(10);
            builder.Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            builder.Property(x => x.Scope).HasColumnName("Scope").IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Description).HasColumnName("Description").HasMaxLength(1000);
            builder.Property(x => x.Status).HasColumnName("Status").HasMaxLength(30);

            /*
             * 
                builder.HasData(

                    new systemsecurity.domain.Application
                    {
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


