using DDDImovel.Domain.Store.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Infra.Mappings
{
    class VendaMap : EntityTypeConfiguration<Venda>
    {
        public VendaMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Valor);
            Property(x => x.DataVenda);

            HasRequired(x => x.Comprador);
            HasRequired(x => x.Vendedor);
            HasRequired(x => x.Imovel);
        }
    }
}
