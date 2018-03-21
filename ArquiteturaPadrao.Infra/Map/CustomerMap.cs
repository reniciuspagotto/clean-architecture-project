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
            builder.HasKey(x => x.Id); //DEFINE A CHAVE PRIMÁRIA DO BANCO

            builder.Ignore(x => x.Notifications);
            builder.Ignore(x => x.Valid);
            builder.Ignore(x => x.Invalid);
        }
    }
}
