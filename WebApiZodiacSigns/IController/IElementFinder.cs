using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiZodiacSigns.Models;

namespace WebApiZodiacSigns.IController
{
    public interface IElementFinder<Element>
    {
        public ReplyElement GetAllElements();
        public ReplyElement GetElementById(int id);
        public ReplyElement GetElementByIdSign(int idSign);
    }
}
