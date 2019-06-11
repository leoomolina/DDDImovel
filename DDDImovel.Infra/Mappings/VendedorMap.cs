using DDDImovel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Infra.Mappings
{
    class VendedorMap : EntityTypeConfiguration<Vendedor>
    {
        public VendedorMap()
        {
            ToTable("Vendedor");
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
