using DDDImovel.Domain.Entities;
using DDDImovel.Shared.Entities;
using System;

namespace DDDImovel.Domain.Entities
{
    public class Venda : Entity
    {
        public Venda(Imovel imovel, DateTime dataVenda, Vendedor vendedor, Comprador comprador)
        {
            DataVenda = dataVenda;
            Imovel = imovel;
            Vendedor = vendedor;
            Comprador = comprador;
        }

        public DateTime DataVenda { get; private set; }
        public int Valor { get; private set; }

        public Imovel Imovel { get; private set; }
        public Comprador Comprador { get; private set; }
        public Vendedor Vendedor { get; private set; }
    }
}