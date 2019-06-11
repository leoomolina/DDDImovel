using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DDDImovel.Domain.Entities;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DDDImovel.Infra.Mappings
{
    class CompradorMap : EntityTypeConfiguration<Comprador>
    {
        public CompradorMap()
        {
            ToTable("Comprador");
            HasKey(x => x.Id);
            Property(x => x.Cpf).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Email.MailAddress).HasMaxLength(60);
            Property(x => x.Name.FirstName).IsRequired().HasMaxLength(40);
            Property(x => x.Name.LastName).HasMaxLength(40);
            Property(x => x.Telefone).HasMaxLength(14);
            Property(x => x.TipoPessoa).HasMaxLength(10);
        }
    }
}
