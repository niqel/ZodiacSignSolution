
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiZodiacSigns.IApis;
using ApiZodiacSigns.Models;

namespace WebApiZodiacSigns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SignFinderController : ControllerBase
    {
        private readonly ISignFinder signFinder;

        public SignFinderController(ISignFinder signFinder)
        {
            this.signFinder = signFinder;
        }

        [HttpGet]
        public Reply<Sign> GetAll()
        {
            var reply = signFinder.GetAll();
            return reply;
        }

        [HttpGet("{id}")]
        public Reply<Sign> Get(int id)
        {
            var reply = signFinder.GetById(id);
            return reply;
        }

        [HttpGet("{idElement}")]
        public Reply<Sign> GetByIdElement(int idElement)
        {
            var reply = signFinder.GetSignByIdElement(idElement);
            return reply;
        }

        [HttpGet("{idPLanet}")]
        public Reply<Sign> GetByIdPlanet(int idPlanet)
        {
            var reply = signFinder.GetSignByIdPlanet(idPlanet);
            return reply;
        }
    }
}
