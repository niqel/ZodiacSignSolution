using System.Collections.Generic;

namespace ApiZodiacSigns.Models
{
    public class Element
    {
        public virtual int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Sign> Signs { get; set; }
    }
}