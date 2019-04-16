using DDDImovel.Shared.Entities;
using System;

namespace DDDImovel.Domain.Store.Entities
{
    public class Venda : Entity
    {
        public Venda(Imovel imovel, DateTime dataVenda, Person vendedor, Person cliente)
        {
            DataVenda = dataVenda;
            Imovel = imovel;
            Vendedor = vendedor;
            Cliente = cliente;
        }

        public Imovel Imovel { get; private set; }
        public DateTime DataVenda { get; private set; }
        public Person Cliente { get; private set; }
        public Person Vendedor { get; private set; }
    }
}