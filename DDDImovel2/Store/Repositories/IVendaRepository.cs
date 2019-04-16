using System;
using System.Collections.Generic;
using DDDImovel.Domain.Store.Entities;

namespace DDDImovel.Domain.Store.Repositories
{
    public interface IVendaRepository
    {
        void Save(Venda venda);
        IEnumerable<Venda> GetOrders();
        Person GetOrderById(Guid personId);
    }
}
