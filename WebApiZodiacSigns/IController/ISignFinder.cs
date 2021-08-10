using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiZodiacSigns.Models;

namespace Controllers.IControllers
{
    public interface ISignFinder<Sign>
    {
        public ReplySign GetAllSigns();
        public ReplySign GetSignById(int id);
        public ReplySign GetSignsByElementId(int idElement);
        public ReplySign GetSignsByPlanetId(int idPlanet);
        public ReplySign GetSignByBirthday(DateTime birthday);
    }
}
