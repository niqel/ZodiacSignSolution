using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiZodiacSigns.Models;
using WebApiZodiacSigns.IController;

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
        public ReplyPlanet GetAll()
        {
            var reply = planetFinder.GetAllPlanets();
            return reply;
        }

        [HttpGet("{id}")]
        public ReplyPlanet Get(int id)
        {
            var reply = planetFinder.GetPlanetById(id);
            return reply;
        }

        [HttpGet("{idSign}")]
        public ReplyPlanet GetByIdPlanet(int idSign)
        {
            var reply = planetFinder.GetPlanetById(idSign);
            return reply;
        }
    }
}
