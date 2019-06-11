using DDDImovel.Domain.ValueObjects;
using DDDImovel.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Domain.Entities
{
    public class Comprador : Entity
    {
        public Comprador(
            Name name,
            string cpf,
            string tipoPessoa
            )
        {
            Name = name;
            Cpf = cpf;
            TipoPessoa = tipoPessoa;
        }

        public Name Name { get; set; }
        public string Cpf { get; set; }
        public Email Email { get; set; }
        public string Telefone { get; set; }
        public string TipoPessoa { get; set; }
    }
}
