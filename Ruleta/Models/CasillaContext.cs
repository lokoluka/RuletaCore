using Microsoft.EntityFrameworkCore;
using Ruleta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruleta.Models
{
    public class CasillaContext : DbContext
    {
        public CasillaContext(DbContextOptions<CasillaContext> options)
            : base(options)
        {
        }

        public DbSet<Casilla> Casillas { get; set; }
    }
}
