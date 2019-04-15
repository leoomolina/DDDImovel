using System;
using DDDImovel.Shared.ValueObject;
using Flunt.Validations;

namespace DDDImovel.Domain.Store.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string mailAddress)
        {
            MailAddress = mailAddress;

            if (String.IsNullOrEmpty(mailAddress))
                AddNotification("mailAddress", "Endereço do e-mail vazio");

        }

        public string MailAddress { get; set; }

    }
}