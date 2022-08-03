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
    public class AnalistasController : Controller
    {
        private readonly IAnalistaRepository _analistaRepository;

        public AnalistasController(IAnalistaRepository analistaRepository)
        {
            _analistaRepository = analistaRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Analista>> GetAnalistas()
        {
            return await _analistaRepository.Get();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Analista>> GetAnalistas(int id)
        {
            return await _analistaRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Analista>> PostAnalistas([FromBody] Analista analista)
        {
            var newAnalista = await _analistaRepository.Create(analista);
            return CreatedAtAction(nameof(GetAnalistas), new { id = newAnalista.Id}, newAnalista);
        }
        
        [HttpPut]
        public async Task<ActionResult> PutAnalistas(int id, [FromBody] Analista analista)
        {
            if (id != analista.Id) {
                return BadRequest();
            }

            await _analistaRepository.Update(analista);

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAnalistas(int id)
        {
            var analistaToDelete = await _analistaRepository.Get(id);
            if (analistaToDelete == null) {
                return NotFound();
            }

            await _analistaRepository.Detete(analistaToDelete.Id);
            return NoContent();
        }
    }
}