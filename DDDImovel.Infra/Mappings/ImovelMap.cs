using DDDImovel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Infra.Mappings
{
    class ImovelMap : EntityTypeConfiguration<Imovel>
    {
        public ImovelMap()
        {
            ToTable("Imovel");
            HasKey(x => x.Id);
        }
    }
}
