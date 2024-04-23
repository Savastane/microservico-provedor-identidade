using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using system.Security.Entity.Collection;
using systemsecurity.domain;
using System.Reflection.Emit;
using Microsoft.Extensions.Options;


namespace system.Security.API.Configuration.Entity
{

    public class EventMigration : IEntityTypeConfiguration<systemsecurity.domain.Event> 
    {
        public void Configure(EntityTypeBuilder<systemsecurity.domain.Event> builder)
        {
            // Nome da tabela
            builder.ToTable("Event");

            builder.HasKey(x => x.Id);                        
            builder.Property(x => x.Id).HasColumnName("Id").IsRequired().HasDefaultValueSql("NEWSEQUENTIALID()");                        
            builder.Property(r => r.GuidUser).HasColumnName("GuidUser").IsRequired();
            builder.Property(r => r.DateEvent).HasColumnName("DateEvent").IsRequired();
            builder.Property(r => r.Command).HasColumnName("Command").HasMaxLength(100).IsRequired();
            builder.Property(r => r.Queue).HasColumnName("Queue").HasMaxLength(100).IsRequired();
            builder.Property(r => r.Topic).HasColumnName("Topic").HasMaxLength(100).IsRequired();
            builder.Property(r => r.Status).HasColumnName("Status").IsRequired(); // 1 process 2-pendent 3=error

            builder.Property(r => r.ProcessCount).HasColumnName("ProcessCount").IsRequired(); // 1 process 2-pendent 3=error
            builder.Property(r => r.DataObject).HasColumnName("DataObject").IsRequired();

            builder.OwnsOne(e => e.Location, builder => { builder.ToJson(); });
            builder.OwnsOne(e => e.ErroCollection, options =>
            {
                options.ToJson();
                options.OwnsMany(colection => colection.Erros);
            });

        }
    }

}


