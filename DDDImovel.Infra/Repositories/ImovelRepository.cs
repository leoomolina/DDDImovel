using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDImovel.Domain.Store.Entities;
using DDDImovel.Infra.Contexts;
using DDDImovel.Domain.Store.Repositories;

namespace DDDImovel.Infra.Repositories
{
    class ImovelRepository : IImovelRepository
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

        public IList<Imovel> GetImovels(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}