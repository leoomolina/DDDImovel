using DDDImovel.Domain.Store.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Domain.Store.Entities
{
    public class Vendedor : Person
    {
        public Vendedor(
            Name name,
            string cpf,
            string tipoPessoa,
            string creci
            ):base(name, cpf, tipoPessoa)
        {
            Name = name;
            Cpf = cpf;
            TipoPessoa = tipoPessoa;
            Creci = creci;
        }

        public string Creci { get; set; }
    }
}
