using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ApiCliente.Data;
using ApiCliente.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext _context;

        public ClienteController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _context.Cliente.AsNoTracking().ToList();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return _context.Cliente.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/<ClienteController>
        [HttpPost]
        public HttpResponseMessage Post([FromBody] Cliente value)
        {
            if (value.cpfValidate(value.Cpf))
            {
                _context.Cliente.Add(value);
                _context.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage();
                return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Cadastro realizado com seucesso") };

            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent("Problema ao validar CPF") };

            }
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public Cliente Put(int id, [FromBody] Cliente value)
        {

            _context.Entry<Cliente>(value).State = EntityState.Modified;
            _context.SaveChanges();

            return value;
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public Cliente Delete([FromBody] Cliente value)
        {
            _context.Cliente.Remove(value);
            _context.SaveChanges();

            return value;
        }
    }
}
