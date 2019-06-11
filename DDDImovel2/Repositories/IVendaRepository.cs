using System;
using System.Collections.Generic;
using DDDImovel.Domain.Entities;

namespace DDDImovel.Domain.Store.Repositories
{
    public interface IVendaRepository
    {
        void Save(Venda venda);

        Imovel GetImovelById(Guid imovelId);

        Comprador GetCompradorById(Guid compradorId);

        Vendedor GetVendedorById(Guid compradorId);
    }
}
