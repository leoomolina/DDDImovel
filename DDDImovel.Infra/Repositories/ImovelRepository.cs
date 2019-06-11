using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDImovel.Domain.Entities;
using DDDImovel.Infra.Contexts;
using DDDImovel.Domain.Repositories;
using System.Data.Entity;

namespace DDDImovel.Infra.Repositories
{
    public class ImovelRepository : IImovelRepository
    {
        private readonly DDDImovelStoreDataContext _context;

        public ImovelRepository(DDDImovelStoreDataContext context)
        {
            _context = context;
        }

        public Imovel Get(Guid id)
        {
            return _context.Imovels.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public Task<List<Imovel>> GetImovels()
        {
            return _context.Imovels.OrderBy(x => x.Id).ToListAsync();
        }

        public void Save(Imovel imovel)
        {
            if (imovel.Valid)
                _context.Imovels.Add(imovel);
            _context.SaveChanges();
        }
    }
}