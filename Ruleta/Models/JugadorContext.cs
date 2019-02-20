using Microsoft.EntityFrameworkCore;
using Ruleta.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruleta.Models
{
    public class JugadorContext: DbContext
    {
        public JugadorContext(DbContextOptions<JugadorContext> options)
               : base(options)
        {
        }

        public DbSet<Jugador> Jugadores { get; set; }
    }
}
