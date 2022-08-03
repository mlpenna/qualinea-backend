using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Qualinea.Models;

namespace Qualinea.Repositories
{
    public interface IRegistroLaudoRepository
    {
        Task<IEnumerable<RegistroLaudo>> Get();
        Task<RegistroLaudo> Get(int id);
        Task<RegistroLaudo> Create(RegistroLaudo registroLaudo);
        Task Update(RegistroLaudo registroLaudo);
        Task Detete(int id);
    }
}