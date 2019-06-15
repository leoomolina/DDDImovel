using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDImovel.Domain.Entities;
using DDDImovel.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DDDImovel.Api.Controllers
{
    [Route("api/vendedor")]
    public class VendedorController : Controller
    {
        private readonly IVendedorRepository _repository;

        public VendedorController(IVendedorRepository repository)
        {
            _repository = repository;
        }

        // GET api/<controller>
        [HttpGet]
        public async Task<List<Vendedor>> GetVendedores()
        {
            return await _repository.GetVendedores();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Vendedor vendedor)
        {
            try
            {
                _repository.Save(vendedor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
