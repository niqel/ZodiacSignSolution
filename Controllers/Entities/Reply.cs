using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Entities
{

    public class Reply<Tentity>
    {
        public bool HasSucces { get; set; }
        public virtual int TotalCount { get; set; }

        public virtual List<Tentity> Items { get; set; }
    }

}
