using DDDImovel.Domain.Store.ValueObjects;
using DDDImovel.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Domain.Store.Entities
{
    public class Person : Entity
    {
        public Person(
            Name nome,
            Email email,
            string telefone,
            string cpf,
            string tipoPessoa
            )
        {
            Name = nome;
            Email = email;
            Telefone = telefone;
            Cpf = cpf;
            TipoPessoa = tipoPessoa;
        }

        public Name Name { get; private set; }
        public Email Email { get; set; }
        public string Telefone { get; private set; }
        public string Cpf { get; private set; }
        public string TipoPessoa { get; private set; }
    }
}
