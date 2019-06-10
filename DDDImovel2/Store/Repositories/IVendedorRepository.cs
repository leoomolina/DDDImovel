using System;
using System.Collections.Generic;
using DDDImovel.Domain.Store.Entities;

namespace DDDImovel.Domain.Store.Repositories
{
    //Aqui definimos as ações relacionadas à Entidade em relação a seu acesso a dados 
    public interface IVendedorRepository
    {
        Vendedor GetById(Guid id);
        void Save(Vendedor vendedor);
        IEnumerable<Vendedor> GetVendedores();

    }

}
