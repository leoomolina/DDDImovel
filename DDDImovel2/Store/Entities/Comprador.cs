using DDDImovel.Domain.Store.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Domain.Store.Entities
{
    public class Comprador : Person
    {
        public Comprador(
            Name name,
            string cpf,
            string tipoPessoa
            ):base(name, cpf, tipoPessoa)
        {
            Name = name;
            Cpf = cpf;
            TipoPessoa = tipoPessoa;
        }
        
    }
}
