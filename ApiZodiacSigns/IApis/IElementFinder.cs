using ApiZodiacSigns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiZodiacSigns.IApis
{
    public interface IElementFinder : IFinder<Element>
    {
        public Reply<Element> GetElementByIdSign(int idSign);
    }
}
