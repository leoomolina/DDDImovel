using DDDImovel.Domain.Store.Entities;
using DDDImovel.Domain.Store.Enums;
using DDDImovel.Domain.Store.Repositories;
using DDDImovel.Domain.Store.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDImovel.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fakeClienteRepository = new FakeClienteRepository();
            var fakeVendedorRepository = new FakeVendedorRepository();
            var fakeImovelRepository = new FakeImovelRepository();
            GerarVenda(fakeClienteRepository, fakeVendedorRepository, fakeImovelRepository);
        }


        public static void GerarVenda(
            IPersonRepository clienteRepository,
            IPersonRepository vendedorRepository,
            IImovelRepository imovelRepository)
        {
            var cliente = clienteRepository.GetById(Guid.NewGuid());
            var imovel = imovelRepository.GetById(Guid.NewGuid());
            var vendedor = vendedorRepository.GetById(Guid.NewGuid());

            var venda = new Venda(imovel, DateTime.Now, vendedor, cliente);
            imovel.Status = Status.Vendido;

        }
    }

    public class FakeImovelRepository : IImovelRepository
    {
        public Imovel GetById(Guid id)
        {
            //É somente um teste, portanto, retornaremos um mesmo produto e sem vínculo de Id(Guid)
            return new Imovel("Imovel1",
                "Descrição Imovel",
                new Address("17500-123", "Rua teste imovel 1", "123", "", "Bairro Teste", "Marilia", "SP", "22.2208", "-49.9486"),
                100000,
                Status.NaoVendido);
        }

        public IList<Imovel> GetImovels(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }

    public class FakeClienteRepository : IPersonRepository
    {

        // Criação Cliente Fake para fazermos testes
        public Person GetById(Guid id)
        {
            var clienteFake = new Person
            (
                new Name("Teste", "Cliente"),
                new Email("teste@teste.com.br"),
                "99123-4567",
                "123.456.789-00",
                "Cliente"
            );
            return clienteFake;
        }

        public void Save(Person cliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPersons()
        {
            throw new NotImplementedException();
        }
    }

    public class FakeVendedorRepository : IPersonRepository
    {

        // Criação Vendedor Fake para fazermos testes
        public Person GetById(Guid id)
        {
            var vendedorFake = new Person
            (
                new Name("Teste", "Vendedor"),
                new Email("teste@teste.com.br"),
                "99123-4567",
                "123.456.789-00",
                "Vendedor"
            );
            return vendedorFake;
        }

        public void Save(Person customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPersons()
        {
            throw new NotImplementedException();
        }
    }

}