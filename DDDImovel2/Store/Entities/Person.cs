using DDDImovel.Domain.Store.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Domain.Store.Entities
{
    class Person
    {
        public Name Name { get; private set; }
        public Email Email { get; set; }
        public string Telefone { get; private set; }
        public string Cpf { get; private set; }
    }
}
