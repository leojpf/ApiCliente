using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCliente.Data;
using ApiCliente.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly DataContext _context;

        public EnderecoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Endereco> Get()
        {
            return _context.Endereco.AsNoTracking().ToList();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Endereco Get(int id)
        {
            return _context.Endereco.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/<ClienteController>
        [HttpPost]
        public Endereco Post([FromBody] Endereco value)
        {
            _context.Endereco.Add(value);
            _context.SaveChanges();

            return value;
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public Endereco Put(int id, [FromBody] Endereco value)
        {
            _context.Entry<Endereco>(value).State = EntityState.Modified;
            _context.SaveChanges();

            return value;
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public Endereco Delete([FromBody] Endereco value)
        {
            _context.Endereco.Remove(value);
            _context.SaveChanges();

            return value;
        }
    }
}
