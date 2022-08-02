using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Qualinea.Models;

namespace Qualinea.Repositories
{
    public interface IAnalistaRepository
    {
       Task<IEnumerable<Analista>> Get();
       Task<Analista> Get(int id);
       Task<Analista> Create(Analista analista);
       Task Update(Analista analista);
       Task Detete(int id);
    }
}