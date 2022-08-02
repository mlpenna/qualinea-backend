using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Qualinea.Models;

namespace Qualinea.Repositories
{
    public interface IFornecedorRepository
    {
       Task<IEnumerable<Fornecedor>> Get();
       Task<Fornecedor> Get(int id);
       Task<Fornecedor> Create(Fornecedor fornecedor);
       Task Update(Fornecedor fornecedor);
       Task Detete(int id);
    }
}