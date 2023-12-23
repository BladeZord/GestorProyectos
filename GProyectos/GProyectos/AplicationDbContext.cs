using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GProyectos.Models;
using Microsoft.EntityFrameworkCore;

namespace GProyectos
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Clients> Clients { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        {

        }
    }
}
