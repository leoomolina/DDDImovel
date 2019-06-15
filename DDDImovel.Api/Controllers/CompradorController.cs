using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDImovel.Domain.Entities;
using DDDImovel.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DDDImovel.Api.Controllers
{
    [Route("api/comprador")]
    public class CompradorController : Controller
    {
        private readonly ICompradorRepository _repository;

        public CompradorController(ICompradorRepository repository)
        {
            _repository = repository;
        }

        // GET api/<controller>
        [HttpGet]
        public async Task<List<Comprador>> GetCompradores()
        {
            return await _repository.GetCompradores();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Comprador comprador)
        {
            try
            {
                _repository.Save(comprador);
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
