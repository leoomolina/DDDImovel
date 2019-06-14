using DDDImovel.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Infra.Transactions
{
    public class Uow : IUow
    {
        private readonly DDDImovelStoreDataContext _context;

        public Uow(DDDImovelStoreDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {

        }
    }
}
