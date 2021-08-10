using Controllers.IControllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiZodiacSigns.Models;

namespace WebApiZodiacSigns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SignFinderController : ControllerBase
    {
        private readonly ISignFinder<Sign> signFinder;

        public SignFinderController(ISignFinder<Sign> signFinder)
        {
            this.signFinder = signFinder;
        }

        [HttpGet]
        public ReplySign GetAll()
        {
            var reply = signFinder.GetAllSigns();
            return reply;
        }

        [HttpGet("{id}")]
        public ReplySign Get(int id)
        {
            var reply = signFinder.GetSignById(id);
            return reply;
        }

        [HttpGet("{idElement}")]
        public ReplySign GetByIdElement(int idElement)
        {
            var reply = signFinder.GetSignsByElementId(idElement);
            return reply;
        }

        [HttpGet("{idPLanet}")]
        public ReplySign getByIdPlanet(int idPlanet)
        {
            var reply = signFinder.GetSignsByPlanetId(idPlanet);
            return reply;
        }
    }
}
