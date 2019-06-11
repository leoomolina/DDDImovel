using System;
using System.Collections.Generic;
using DDDImovel.Domain.Entities;

namespace DDDImovel.Domain.Repositories
{
    public interface IImovelRepository
    {
        Imovel Get(Guid id);
        IList<Imovel> GetImovels(List<Guid> ids);
    }
}
