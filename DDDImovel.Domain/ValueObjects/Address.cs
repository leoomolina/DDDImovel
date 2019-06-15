using DDDImovel.Shared.ValueObject;
using System;
using System.Collections.Generic;
using Flunt.Validations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(
            string cep,
            string endereco,
            string numero,
            string complemento,
            string bairro,
            string cidade,
            string estado,
            string latitude,
            string longitude)
        {
            Cep = cep;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Latitude = latitude;
            Longitude = longitude;

            AddNotifications(
                new Contract()
                    .Requires()
                .IsTrue(Validate(), "cep", "CEP não deve ser vazio"),
                new Contract()
                    .Requires()
                .IsTrue(Validate(), "endereco", "Endereco não deve ser vazio"),
                new Contract()
                    .Requires()
                .IsTrue(Validate(), "numero", "Número não deve ser vazio"),
                new Contract()
                    .Requires()
                .IsTrue(Validate(), "bairro", "Bairro não deve ser vazio"),
                new Contract()
                    .Requires()
                .IsTrue(Validate(), "cidade", "Cidade não deve ser vazio"),
                new Contract()
                    .Requires()
                .IsTrue(Validate(), "estado", "Estado não deve ser vazio"),
                new Contract()
                    .Requires()
                .IsTrue(Validate(), "latitude", "Latitude não deve ser vazio"),
                new Contract()
                    .Requires()
                .IsTrue(Validate(), "longitude", "Longitude não deve ser vazio")
                );
        }

        private bool Validate()
        {
            if (!String.IsNullOrEmpty(Cep))
                return true;

            if (!String.IsNullOrEmpty(Endereco))
                return true;

            if (!String.IsNullOrEmpty(Numero))
                return true;

            if (!String.IsNullOrEmpty(Bairro))
                return true;

            if (!String.IsNullOrEmpty(Cidade))
                return true;

            if (!String.IsNullOrEmpty(Estado))
                return true;

            if (!String.IsNullOrEmpty(Latitude))
                return true;

            if (!String.IsNullOrEmpty(Longitude))
                return true;

            return false;
        }

        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

    }
}
