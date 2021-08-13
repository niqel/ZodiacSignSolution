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
    public class ElementFinderController : ControllerBase
    {
        private readonly IElementFinder elementFinder;

        public ElementFinderController(IElementFinder elementFinder)
        {
            this.elementFinder = elementFinder;
        }

        [HttpGet]
        public Reply<Element> GetAll()
        {
            var reply = elementFinder.GetAll();
            return reply;
        }

        [HttpGet("{id}")]
        public Reply<Element> Get(int id)
        {
            var reply = elementFinder.GetById(id);
            return reply;
        }

        [HttpGet("{idElement}")]
        public Reply<Element> GetElementBySign(int idSign)
        {
            var reply = elementFinder.GetById(idSign);
            return reply;
        }
    }
}
