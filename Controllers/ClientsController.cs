using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba1.Dtos;
using Prueba1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Prueba1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly Prueba1Context _PruebaContexto;
        private readonly IMapper _mapper;

        public ClientsController(Prueba1Context prueba1Context, IMapper mapper)
        {
            _PruebaContexto = prueba1Context;
            _mapper = mapper;
        }
        // GET: api/<ClientsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetAllClients()
        {
            var response = await _PruebaContexto.Clientes.ToListAsync();
            var mapp = _mapper.Map<IEnumerable<ClienteDto>>(response);
            return Ok(mapp);
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteDto>> GetClient(int id)
        {
            var response = await _PruebaContexto.Clientes.FindAsync(id);

            if (response == null) return NotFound();
            var mapp = _mapper.Map<ClienteDto>(response);
            return mapp;
        }

        // POST api/<ClientsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
