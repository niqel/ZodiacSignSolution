using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiZodiacSigns.IController;
using WebApiZodiacSigns.Models;

namespace WebApiZodiacSigns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ElementFinderController : ControllerBase
    {
        private readonly IElementFinder<Element> elementFinder;

        public ElementFinderController(IElementFinder<Element> elementFinder)
        {
            this.elementFinder = elementFinder;
        }

        [HttpGet]
        public ReplyElement GetAll()
        {
            var reply = elementFinder.GetAllElements();
            return reply;
        }

        [HttpGet("{id}")]
        public ReplyElement Get(int id)
        {
            var reply = elementFinder.GetElementById(id);
            return reply;
        }

        [HttpGet("{idElement}")]
        public ReplyElement GetByIdElement(int idSign)
        {
            var reply = elementFinder.GetElementByIdSign(idSign);
            return reply;
        }
    }
}
