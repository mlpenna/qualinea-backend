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
    public class FornecedorController : Controller
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorController(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Fornecedor>> GetFornecedores()
        {
            return await _fornecedorRepository.Get();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Fornecedor>> GetFornecedores(int id)
        {
            return await _fornecedorRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Fornecedor>> PostFornecedores([FromBody] Fornecedor fornecedor)
        {
            var newFornecedor = await _fornecedorRepository.Create(fornecedor);
            return CreatedAtAction(nameof(GetFornecedores), new { id = newFornecedor.Id}, newFornecedor);
        }
        
        [HttpPut]
        public async Task<ActionResult> PutFornecedores(int id, [FromBody] Fornecedor fornecedor)
        {
            if (id != fornecedor.Id) {
                return BadRequest();
            }

            await _fornecedorRepository.Update(fornecedor);

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteFornecedores(int id)
        {
            var fornecedorToDelete = await _fornecedorRepository.Get(id);
            if (fornecedorToDelete == null) {
                return NotFound();
            }

            await _fornecedorRepository.Detete(fornecedorToDelete.Id);
            return NoContent();
        }
    }
}