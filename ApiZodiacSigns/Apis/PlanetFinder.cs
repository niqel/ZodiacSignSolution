using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiZodiacSigns.IApis;
using ApiZodiacSigns.Models;

namespace ApiZodiacSigns.Apis
{
    public class PlanetFinder : IPlanetFinder
    {
        public Reply<Planet> GetAll()
        {
            throw new NotImplementedException();
        }

        public Reply<Planet> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Reply<Planet> GetPlanetByIdSign(int idSign)
        {
            throw new NotImplementedException();
        }
    }
}
