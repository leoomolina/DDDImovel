using System;
using System.Collections.Generic;
using DDDImovel.Domain.Store.Entities;

namespace DDDImovel.Domain.Store.Repositories
{
    //Aqui definimos as ações relacionadas à Entidade em relação a seu acesso a dados 
    public interface ICompradorRepository
    {
        Comprador GetById(Guid id);
        void Save(Comprador comprador);
    }

}
