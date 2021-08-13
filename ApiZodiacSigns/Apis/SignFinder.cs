using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiZodiacSigns.IApis;
using ApiZodiacSigns.Models;

namespace ApiZodiacSigns.Apis
{
    public class SignFinder : ISignFinder
    {
        public Reply<Sign> GetAll()
        {
            throw new NotImplementedException();
        }

        public Reply<Sign> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Reply<Sign> GetSignByBirthday(DateTime birthday)
        {
            throw new NotImplementedException();
        }

        public Reply<Sign> GetSignByIdElement(int idElement)
        {
            throw new NotImplementedException();
        }

        public Reply<Sign> GetSignByIdPlanet(int IdPlanet)
        {
            throw new NotImplementedException();
        }
    }
}
