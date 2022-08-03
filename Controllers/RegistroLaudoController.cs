using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Qualinea.Models;
using Qualinea.Repositories;

namespace Qualinea.Controllers
{
    [Route("[controller]")]
    public class RegistroLaudoController : Controller
    {
        private readonly IRegistroLaudoRepository _registroLaudoRepository;

        public RegistroLaudoController(IRegistroLaudoRepository registroLaudoRepository)
        {
            _registroLaudoRepository = registroLaudoRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<RegistroLaudo>> GetRegistroLaudos()
        {
            return await _registroLaudoRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RegistroLaudo>> GetRegistroLaudos(int id)
        {
            return await _registroLaudoRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<RegistroLaudo>> PostRegistroLaudos([FromBody] RegistroLaudo registroLaudo)
        {
            var newRegistroLaudo = await _registroLaudoRepository.Create(registroLaudo);
            return CreatedAtAction(nameof(GetRegistroLaudos), new { id = newRegistroLaudo.Id }, newRegistroLaudo);
        }

        [HttpPut]
        public async Task<ActionResult> PutRegistroLaudos(int id, [FromBody] RegistroLaudo registroLaudo)
        {
            if (id != registroLaudo.Id)
            {
                return BadRequest();
            }

            await _registroLaudoRepository.Update(registroLaudo);

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteRegistroLaudos(int id)
        {
            var registroLaudoToDelete = await _registroLaudoRepository.Get(id);
            if (registroLaudoToDelete == null)
            {
                return NotFound();
            }

            await _registroLaudoRepository.Detete(registroLaudoToDelete.Id);
            return NoContent();
        }
    }
}