using DDDImovel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Domain.Repositories
{
    public interface IVendedorRepository
    {
        Vendedor GetById(Guid id);

        void Save(Vendedor vendedor);

        Task<List<Vendedor>> GetVendedores();
    }
}
