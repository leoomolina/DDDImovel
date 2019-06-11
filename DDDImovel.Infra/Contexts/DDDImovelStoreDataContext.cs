using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDImovel.Domain.Entities;
using DDDImovel.Infra.Mappings;

namespace DDDImovel.Infra.Contexts
{
    public class DDDImovelStoreDataContext : DbContext
    {

        public DDDImovelStoreDataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BestLocationDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            //Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Comprador> Compradores { get; set; }
        public DbSet<Imovel> Imovels { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ImovelMap());
            modelBuilder.Configurations.Add(new CompradorMap());
            modelBuilder.Configurations.Add(new VendedorMap());
            modelBuilder.Configurations.Add(new VendaMap());
        }
    }
}
