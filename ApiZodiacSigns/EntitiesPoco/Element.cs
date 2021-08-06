using System.Collections.Generic;

namespace ApiZodiacSigns.EntitiesPoco
{
    public class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Sign> Signs { get; set; }
    }
}