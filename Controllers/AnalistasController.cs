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
        public async Task<ActionResult<Analista>> GetAnalista(int id)
        {
            return await _analistaRepository.Get(id);
        }
    }
}