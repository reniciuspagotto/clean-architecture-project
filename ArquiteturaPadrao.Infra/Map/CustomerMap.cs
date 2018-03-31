using ArquiteturaPadrao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArquiteturaPadrao.Infra.Map
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer"); //DEFINE O NOME DA TABELA
            builder.HasKey(p => p.Id); //DEFINE A CHAVE PRIMÁRIA DO BANCO

            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(60);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(60);
            builder.Property(p => p.Birthdate).IsRequired();
            builder.Property(p => p.PhoneNumber).HasMaxLength(20);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(200);

            builder.HasOne(p => p.User);
        }
    }
}
