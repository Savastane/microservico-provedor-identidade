using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using systemsecurity.domain;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace system.Security.API.Configuration.Entity
{

    public class PessoaMigration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            // Nome da tabela
            builder.ToTable("Pessoa");

            // Chave primária
            builder.HasKey(p => p.Id);

            // Propriedades
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd(); // Define que o valor da chave primária é gerado automaticamente ao ser adicionado.

            builder.Property(p => p.Guid)
                .IsRequired(); // Define que o campo Guid é obrigatório.

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Alcunha)
                .HasMaxLength(50);                       

            builder.Property(p => p.Bloqueado)
                .IsRequired();

            

            // Configuração de índices, chaves estrangeiras, etc., se necessário

            // Exemplo de índice único na propriedade IdExterno
            builder.HasIndex(p => p.Guid).IsUnique();
        }
    }

}


