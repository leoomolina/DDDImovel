using DDDImovel.Domain.Store.ValueObjects;
using DDDImovel.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Domain.Store.Entities
{
    public class Imovel : Entity
    {
        public Imovel(
            string title,
            string description,
            Address address,
            decimal price
            )
        {
            Title = title;
            Description = description;
            Address = address;
            Price = price;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public Address Address { get; private set; }
        public decimal Price { get; private set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
