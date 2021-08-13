using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiZodiacSigns.IApis;
using ApiZodiacSigns.Models;

namespace ApiZodiacSigns.Apis
{
    class ElementFinder : IElementFinder
    {
        public Reply<Element> GetAll()
        {
            throw new NotImplementedException();
        }

        public Reply<Element> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Reply<Element> GetElementByIdSign(int idSign)
        {
            throw new NotImplementedException();
        }
    }
}
