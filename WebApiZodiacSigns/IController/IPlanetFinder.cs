using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiZodiacSigns.Models;

namespace WebApiZodiacSigns.IController
{
    public interface IPlanetFinder
    {
        public ReplyPlanet GetAllPlanets();
        public ReplyPlanet GetPlanetById(int id);
        public ReplyPlanet GetPlanetByIdSign(int idSign);
    }
}
