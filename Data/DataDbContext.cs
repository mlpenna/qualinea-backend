using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Qualinea.Models;

namespace Qualinea.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Analista> Analistas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}