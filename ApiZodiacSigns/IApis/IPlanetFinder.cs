using ApiZodiacSigns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiZodiacSigns.IApis
{
    public interface IPlanetFinder : IFinder<Planet>
    {
        public Reply<Planet> GetPlanetByIdSign(int idSign);
    }
}
