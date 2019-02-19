using Ruleta.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruleta.Services
{
    public class JugadorServices: IJugadorServices
    {
        private readonly Dictionary<string, Jugador> _jugadores;

        public JugadorServices()
        {
            _jugadores = new Dictionary<string, Jugador>();
        }

        public Jugador AddJugador(Jugador jugador)
        {
            _jugadores.Add(jugador.Nombre, jugador);
            return jugador;
        }

        public Dictionary<string, Jugador> getJugadores()
        {
            return _jugadores;
        }
    }
}
