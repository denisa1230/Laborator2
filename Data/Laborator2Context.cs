using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Laborator2.Models;

namespace Laborator2.Data
{
    public class Laborator2Context : DbContext
    {
        public Laborator2Context (DbContextOptions<Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Laborator2.Models.Publisher> Publisher { get; set; }
    }
}
