using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Qualinea.Models;

namespace Qualinea.Repositories
{
    public interface IInsumoRepository
    {
        Task<IEnumerable<Insumo>> Get();
        Task<Insumo> Get(int id);
        Task<Insumo> Create(Insumo insumo);
        Task Update(Insumo insumo);
        Task Detete(int id);
    }
}