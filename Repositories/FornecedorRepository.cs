using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Qualinea.Data;
using Qualinea.Models;

namespace Qualinea.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly DataDbContext _context;

        public FornecedorRepository(DataDbContext context)
        {
            _context = context;
        }

        public async Task<Fornecedor> Create(Fornecedor fornecedor)
        {
            _context.Fornecedores.Add(fornecedor);
            await _context.SaveChangesAsync();

            return fornecedor;
        }

        public async Task Detete(int id)
        {
            var fornecedorToDelete = await _context.Fornecedores.FindAsync(id);
            _context.Fornecedores.Remove(fornecedorToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Fornecedor>> Get()
        {
            return await _context.Fornecedores.ToListAsync();
        }

        public async Task<Fornecedor> Get(int id)
        {
            return await _context.Fornecedores.FindAsync(id);
        }

        public async Task Update(Fornecedor fornecedor)
        {
            _context.Entry(fornecedor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}