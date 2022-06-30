using AppSquadra.Dominio.Models;
using AppSquadra.Infra.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppSquadra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaoLeadController : ControllerBase
    {
        // GET: api/<CartaoLeadController>
        [HttpGet]
        public async Task<ActionResult<List<CartaoLeadAccpted>>> Get([FromServices] DataContext context)
        {            
            var dados = await context.CartaoLeads.Where(x=>x.Status == 0).ToListAsync();
            if (dados.Any())
            {
                return Ok(dados);

            }
            return NotFound();
        }

        // GET api/<CartaoLeadController>/5
        [HttpGet("{status}")]
        public async Task<ActionResult<List<CartaoLeadAccpted>>> Get([FromServices] DataContext context, int status)
        {
            
            var dados = await context.CartaoLeads.Where(x => x.Status == status).ToListAsync();
            if (dados.Any())
            {
              return Ok(dados);

            }
            return NotFound();
        }

        // POST api/<CartaoLeadController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CartaoLeadController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromQuery] int value,[FromServices] DataContext context)
        {
            var cartao = await context.CartaoLeads.FindAsync(id); 

            if (cartao.Price > 500)
            {
                cartao.Price = cartao.Price - (10 / 100 * cartao.Price);
            }

            //enviar email

            cartao.Status = value;

            context.Update(cartao);

            await context.SaveChangesAsync();

            return Ok(context.CartaoLeads.ToList());
        }

        // DELETE api/<CartaoLeadController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
