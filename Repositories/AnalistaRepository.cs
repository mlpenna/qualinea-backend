using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Qualinea.Data;
using Qualinea.Models;

namespace Qualinea.Repositories
{
    public class AnalistaRepository : IAnalistaRepository
    {
        private readonly DataDbContext _context;

        public AnalistaRepository(DataDbContext context)
        {
            _context = context;
        }

        public async Task<Analista> Create(Analista analista)
        {
            _context.Analistas.Add(analista);
            await _context.SaveChangesAsync();

            return analista;
        }

        public async Task Detete(int id)
        {
            var analistaToDelete= await _context.Analistas.FindAsync(id);
            _context.Analistas.Remove(analistaToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Analista>> Get()
        {
            return await _context.Analistas.ToListAsync();
        }

        public async Task<Analista> Get(int id)
        {
            return await _context.Analistas.FindAsync(id);
        }

        public async Task Update(Analista analista)
        {
            _context.Entry(analista).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}