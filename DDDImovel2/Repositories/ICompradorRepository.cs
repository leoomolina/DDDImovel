using DDDImovel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Domain.Repositories
{
    public interface ICompradorRepository
    {
        Comprador GetById(Guid id);

        void Save(Comprador comprador);

        Task<List<Comprador>> GetCompradores();
    }
}
