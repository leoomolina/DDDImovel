using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DDDImovel.Domain.Entities;

namespace DDDImovel.Domain.Repositories
{
    public interface IImovelRepository
    {
        void Save(Imovel imovel);

        Imovel Get(Guid id);

        Task<List<Imovel>> GetImovels();
    }
}
