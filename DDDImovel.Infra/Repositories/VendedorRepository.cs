using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDImovel.Domain.Entities;
using DDDImovel.Domain.Repositories;
using DDDImovel.Infra.Contexts;

namespace DDDImovel.Infra.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly DDDImovelStoreDataContext _context;

        public VendedorRepository(DDDImovelStoreDataContext context)
        {
            _context = context;
        }

        public Vendedor GetById(Guid id)
        {
            return _context.Vendedores.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public Task<List<Vendedor>> GetVendedores()
        {
            return _context.Vendedores.OrderBy(d => d.Id).ToListAsync();
        }

        public void Save(Vendedor vendedor)
        {
            if (vendedor.Valid)
                _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
        }
    }
}
