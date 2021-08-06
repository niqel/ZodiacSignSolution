using System.Collections.Generic;

namespace ApiZodiacSigns.EntitiesPoco
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Sign> Signs { get; set; }
    }
}