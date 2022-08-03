using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Qualinea.Data;
using Qualinea.Models;

namespace Qualinea.Repositories
{
    public class RegistroLaudoRepository : IRegistroLaudoRepository
    {
        private readonly DataDbContext _context;

        public RegistroLaudoRepository(DataDbContext context)
        {
            _context = context;
        }

        public async Task<RegistroLaudo> Create(RegistroLaudo registroLaudo)
        {
            _context.RegistroLaudos.Add(registroLaudo);
            await _context.SaveChangesAsync();

            return registroLaudo;
        }

        public async Task Detete(int id)
        {
            var registroLaudoToDelete = await _context.RegistroLaudos.FindAsync(id);
            _context.RegistroLaudos.Remove(registroLaudoToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<RegistroLaudo>> Get()
        {
            return await _context.RegistroLaudos.ToListAsync();
        }

        public async Task<RegistroLaudo> Get(int id)
        {
            return await _context.RegistroLaudos.FindAsync(id);
        }

        public async Task Update(RegistroLaudo registroLaudo)
        {
            _context.Entry(registroLaudo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}