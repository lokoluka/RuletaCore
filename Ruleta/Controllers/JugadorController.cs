using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ruleta.Services;

namespace Ruleta.Controllers
{
    [Route("api/")]
    [ApiController]
    public class JugadorController : ControllerBase
    {
        private readonly IJugadorServices _services;

        public JugadorController(IJugadorServices services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("AddJugador")]
        public ActionResult<Jugador> AddJugador(Jugador jugador)
        {
            var Jugador =  _services.AddJugador(jugador);
            if (Jugador == null)
            {
                return NotFound();
            }
            return Ok(Jugador);
        }

        [HttpGet]
        [Route("GetJugadores")]
        public ActionResult<Dictionary<string, Jugador>> GetJugadores()
        {
            var Jugadores = _services.getJugadores();
            if (Jugadores.Count == 0)
            {
                return NotFound();
            }

            return Jugadores;
            
        }
    }
}