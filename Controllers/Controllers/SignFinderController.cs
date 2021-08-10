using Controllers.IControllers;
using Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SignFinderController : ControllerBase
    {
        private readonly ISignFinder<Sign> signFinder;

        public SignFinderController(ISignFinder<Sign> signFinder)
        {
            this.signFinder = signFinder;
        }

        [HttpGet]
        public IEnumerable<Sign> GetAll()
        {
            var reply = signFinder.GetAllSigns();
            return reply.Items;
        }

        [HttpGet ("{id}")]
        public Sign Get(int id)
        {
            var reply = signFinder.GetSignById(id);
            return reply.Items.FirstOrDefault();
        }

        [HttpGet("{idElement}")]
        public IEnumerable<Sign> GetByIdElement(int idElement)
        {
            var reply = signFinder.GetSignsByElementId(idElement);
            return reply.Items;
        }

        [HttpGet("{idPLanet}")]
        public IEnumerable<Sign> getByIdPlanet(int idPlanet)
        {
            var reply = signFinder.GetSignsByPlanetId(idPlanet);
            return reply.Items;
        }
    }
}
