using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ruleta.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ruleta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasillaController : ControllerBase
    {
        private readonly Context _db ;

        public CasillaController(Context context)
        {
            _db = context; 

        }




        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return new Casilla (id).ToString();
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
