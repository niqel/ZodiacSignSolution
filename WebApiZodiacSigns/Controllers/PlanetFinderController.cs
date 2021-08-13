using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiZodiacSigns.Models;
using ApiZodiacSigns.IApis;

namespace WebApiZodiacSigns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlanetFinderController : ControllerBase
    {
        private IPlanetFinder planetFinder;

        public PlanetFinderController(IPlanetFinder planetFinder)
        {
            this.planetFinder = planetFinder;
        }

        [HttpGet]
        public Reply<Planet> GetAll()
        {
            var reply = planetFinder.GetAll();
            return reply;
        }

        [HttpGet("{id}")]
        public Reply<Planet> Get(int id)
        {
            var reply = planetFinder.GetById(id);
            return reply;
        }

        [HttpGet("{idSign}")]
        public Reply<Planet> GetByIdPlanet(int idSign)
        {
            var reply = planetFinder.GetPlanetByIdSign(idSign);
            return reply;
        }
    }
}
