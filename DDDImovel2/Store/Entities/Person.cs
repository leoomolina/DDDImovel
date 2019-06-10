﻿using DDDImovel.Domain.Store.ValueObjects;
using DDDImovel.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Domain.Store.Entities
{
    public abstract class Person : Entity
    {
        public Person(
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
        public Email Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string TipoPessoa { get; set; }
    }
}
