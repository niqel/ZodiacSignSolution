using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiZodiacSigns.Models;

namespace ApiZodiacSigns.IApis
{
    public interface ISignFinder : IFinder<Sign>
    {
        public Reply<Sign> GetSignByBirthday(DateTime birthday);
        public Reply<Sign> GetSignByIdElement(int idElement);
        public Reply<Sign> GetSignByIdPlanet(int IdPlanet);
    }
}
