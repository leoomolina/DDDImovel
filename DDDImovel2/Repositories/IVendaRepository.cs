using System;
using System.Collections.Generic;
using DDDImovel.Domain.Entities;

namespace DDDImovel.Domain.Repositories
{
    public interface IVendaRepository
    {
        void Save(Venda venda);

        Venda GetVendaById(Guid vendaId);

        List<Venda> GetVendas();
    }
}
