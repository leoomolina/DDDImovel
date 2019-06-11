using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDImovel.Domain.Entities;
using DDDImovel.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DDDImovel.Api.Controllers
{
    [Route("api/[controller]")]
    public class VendaController : Controller
    {
        private readonly IVendaRepository _repository;

        public VendaController(IVendaRepository repository)
        {
            _repository = repository;
        }

        // GET api/<controller>
        [HttpGet]
        public List<Venda> GetVendas()
        {
            return _repository.GetVendas();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Venda venda)
        {
            try
            {
                _repository.Save(venda);
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
