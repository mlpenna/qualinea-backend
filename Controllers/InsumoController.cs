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
    public class InsumoController : Controller
    {
        private readonly IInsumoRepository _insumoRepository;

        public InsumoController(IInsumoRepository insumoRepository)
        {
            _insumoRepository = insumoRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Insumo>> GetInsumos()
        {
            return await _insumoRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Insumo>> GetInsumos(int id)
        {
            return await _insumoRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Insumo>> PostInsumos([FromBody] Insumo insumo)
        {
            var newInsumo = await _insumoRepository.Create(insumo);
            return CreatedAtAction(nameof(GetInsumos), new { id = newInsumo.Id }, newInsumo);
        }

        [HttpPut]
        public async Task<ActionResult> PutInsumos(int id, [FromBody] Insumo insumo)
        {
            if (id != insumo.Id)
            {
                return BadRequest();
            }

            await _insumoRepository.Update(insumo);

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteInsumos(int id)
        {
            var insumoToDelete = await _insumoRepository.Get(id);
            if (insumoToDelete == null)
            {
                return NotFound();
            }

            await _insumoRepository.Detete(insumoToDelete.Id);
            return NoContent();
        }
    }
}