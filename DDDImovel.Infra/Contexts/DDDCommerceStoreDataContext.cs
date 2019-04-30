using DDDImovel.Domain.Store.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Enable-Migrations
//
//Update-Database
namespace DDDImovel.Infra.Contexts
{
    public class DDDCommerceStoreDataContext : DbContext
    {
        public DDDCommerceStoreDataContext() : base (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BestLocationDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Imovel> Imovels { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
