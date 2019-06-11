using DDDImovel.Domain.Entities;
using DDDImovel.Domain.Enums;
using DDDImovel.Domain.Repositories;
using DDDImovel.Domain.ValueObjects;
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
            var fakeCompradorRepository = new FakeCompradorRepository();
            var fakeVendedorRepository = new FakeVendedorRepository();
            var fakeImovelRepository = new FakeImovelRepository();
            GerarVenda(fakeCompradorRepository, fakeVendedorRepository, fakeImovelRepository);
        }


        public static void GerarVenda(
            ICompradorRepository compradorRepository,
            IVendedorRepository vendedorRepository,
            IImovelRepository imovelRepository)
        {
            var comprador = compradorRepository.GetById(Guid.NewGuid());
            var imovel = imovelRepository.Get(Guid.NewGuid());
            var vendedor = vendedorRepository.GetById(Guid.NewGuid());

            var venda = new Venda(imovel, DateTime.Now, vendedor, comprador);
            imovel.Status = Status.Vendido;

        }
    }

    public class FakeImovelRepository : IImovelRepository
    {
        public Imovel Get(Guid id)
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

    public class FakeCompradorRepository : ICompradorRepository
    {

        // Criação Comprador Fake para fazermos testes
        public Comprador GetById(Guid id)
        {
            var compradorFake = new Comprador
            (
                new Name("Teste", "Comprador"),
                "123.456.789-00",
                "Comprador"
            );

            return compradorFake;
        }

        public void Save(Comprador comprador)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comprador>> GetCompradores()
        {
            throw new NotImplementedException();
        }
    }

    public class FakeVendedorRepository : IVendedorRepository
    {

        // Criação Vendedor Fake para fazermos testes
        public Vendedor GetById(Guid id)
        {
            var vendedorFake = new Vendedor
            (
                new Name("Teste", "Vendedor"),
                "123.456.789-00",
                "Vendedor",
                "123.456-00"
            );

            return vendedorFake;
        }

        public void Save(Vendedor vendedor)
        {
            throw new NotImplementedException();
        }

        public Task<List<Vendedor>> GetVendedores()
        {
            throw new NotImplementedException();
        }
    }

}