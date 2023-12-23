using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GProyectos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GProyectos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public ClientController(AplicationDbContext context)
        {
            _context = context;
        }


        // GET: api/<ClientController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listClient = await _context.Clients.ToListAsync();
                return Ok(listClient);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Clients client)
        {
            try
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return Ok(client);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Clients client)
        {
            try
            {
                if(id != client.Id)
                {
                    return NotFound();
                }
                _context.Update(client);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Los datos del cliente " + client.Empresa + " fueron actualizados" }) ;
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
