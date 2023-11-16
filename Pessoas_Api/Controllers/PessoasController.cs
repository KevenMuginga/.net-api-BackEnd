using Microsoft.AspNetCore.Mvc;
using Pessoas_CoreShared.Pessoa;
using Pessoas_Manager.interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pessoas_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoaManager manager;
        public PessoasController(IPessoaManager manager)
        {
            this.manager = manager;
        }

        // GET: api/<PessoasController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await manager.GetAsync());
        }

        // GET api/<PessoasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(manager.GetAsync(id));
        }

        // POST api/<PessoasController>
        [HttpPost]
        public async Task<IActionResult> Post(NovaPessoa novaPessoa)
        {
            var paciente = await manager.PostAsync(novaPessoa);
            return CreatedAtAction(nameof(Get), new { id = paciente.Id }, novaPessoa);
        }

        // PUT api/<PessoasController>/5
        [HttpPut]
        public async Task<IActionResult> Put(AlterarPessoa alterarPessoa)
        {
            var pessoa = await manager.GetAsync(alterarPessoa.Id);
            if (pessoa != null)
            {
                return Ok(await manager.UpdateAsync(alterarPessoa));
            }
            return NoContent();
        }

        // DELETE api/<PessoasController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await manager.DeleteAsync(id);
            return NoContent();
        }
    }
}
