using System;
using System.Collections.Generic;
using System.Text;

namespace DDDImovel.Domain.Imobiliaria.Entities
{
    class Imovel
    {
        public Imovel(string cep, string endereco, string cidade, float valor)
        {
            Cep = cep;
            Endereco = endereco;
            Cidade = cidade;
            Valor = valor;

            // Regra: nenhum Imovel poderá ter CEP vazio
            if (string.IsNullOrEmpty(cep))
                throw new Exception("CEP não pode ser vazio");
        }

        public String Cep { get; private set; }
        public String Endereco { get; private set; }
        public String Cidade { get; private set; }
        public float Valor { get; private set; }
    }
}
