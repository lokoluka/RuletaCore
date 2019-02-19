using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ruleta.Controllers;

namespace Ruleta.Services
{
    public interface IJugadorServices
    {
        Jugador AddJugador(Jugador jugador);
        Dictionary<string, Jugador> getJugadores();
    }
}
