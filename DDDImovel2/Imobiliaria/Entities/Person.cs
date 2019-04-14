using System;
using System.Collections.Generic;
using System.Text;

namespace DDDImovel.Domain.Imobiliaria.Entities
{
    class Person
    {
        public Person(string firstName, string lastName, string cpf, string email, string telefone)
        {
            FirstName = firstName;
            LastName = lastName;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;

            // Regra: nenhum Person poderá ter nome, CPF e email VAZIOS
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(email))
                throw new Exception("Nome, sobrenome, email e documento não devem ser nulos ou vazios");
        }

        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public String Cpf { get; private set; }
        public String Email { get; private set; }
        public String Address { get; private set; }
        public String Telefone { get; private set; }
    }
}
