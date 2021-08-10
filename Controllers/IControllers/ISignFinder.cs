using Controllers.Entities;
using Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.IControllers
{
    public interface ISignFinder<Sign>
    {
        public Reply<Sign> GetAllSigns();
        public Reply<Sign> GetSignById(int id);
        public Reply<Sign> GetSignsByElementId(int idElement);
        public Reply<Sign> GetSignsByPlanetId(int idPlanet);
    }
}
