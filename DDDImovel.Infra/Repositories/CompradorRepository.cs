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
    class CompradorRepository : ICompradorRepository
    {
        private readonly DDDImovelStoreDataContext _context;

        public CompradorRepository(DDDImovelStoreDataContext context)
        {
            _context = context;
        }

        public Comprador GetById(Guid id)
        {
            return _context.Compradores.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public Task<List<Comprador>> GetCompradores()
        {
            return _context.Compradores.OrderBy(d => d.Id).ToListAsync();
        }

        public void Save(Comprador comprador)
        {
            if (comprador.Valid)
                _context.Compradores.Add(comprador);
            _context.SaveChanges();
        }
    }
}
