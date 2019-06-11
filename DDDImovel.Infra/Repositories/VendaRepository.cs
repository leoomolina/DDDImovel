using DDDImovel.Domain.Entities;
using DDDImovel.Domain.Repositories;
using DDDImovel.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Infra.Repositories
{
    class VendaRepository : IVendaRepository
    {
        private readonly DDDImovelStoreDataContext _context;

        public VendaRepository(DDDImovelStoreDataContext context)
        {
            _context = context;
        }

        public List<Venda> GetVendas()
        {
            return _context.Vendas.ToList();
        }

        public Venda GetVendaById(Guid id)
        {
            return _context.Vendas.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Save(Venda venda)
        {
            if (venda.Valid)
                _context.Vendas.Add(venda);
            _context.SaveChanges();
        }
    }
}
