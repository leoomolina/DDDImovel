using System;
using System.Collections.Generic;
using DDDImovel.Domain.Store.Entities;

namespace DDDImovel.Domain.Store.Repositories
{
    public interface IImovelRepository
    {
        Imovel GetById(Guid id);
        IList<Imovel> GetImovels(List<Guid> ids);

    }
}
