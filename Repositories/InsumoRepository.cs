using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Qualinea.Data;
using Qualinea.Models;

namespace Qualinea.Repositories
{
    public class InsumoRepository : IInsumoRepository
    {
        private readonly DataDbContext _context;

        public InsumoRepository(DataDbContext context)
        {
            _context = context;
        }

        public async Task<Insumo> Create(Insumo insumo)
        {
            _context.Insumos.Add(insumo);
            await _context.SaveChangesAsync();

            return insumo;
        }

        public async Task Detete(int id)
        {
            var insumoToDelete = await _context.Insumos.FindAsync(id);
            _context.Insumos.Remove(insumoToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Insumo>> Get()
        {
            return await _context.Insumos.ToListAsync();
        }

        public async Task<Insumo> Get(int id)
        {
            return await _context.Insumos.FindAsync(id);
        }

        public async Task Update(Insumo insumo)
        {
            _context.Entry(insumo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}