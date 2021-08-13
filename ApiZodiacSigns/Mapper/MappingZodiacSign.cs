using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiZodiacSigns.Models;

namespace ApiZodiacSigns.Mapper
{
    public class MappingZodiacSign : Profile
    {
        public MappingZodiacSign()
        {
            //Sign
            CreateMap<Entities.Sign, Sign>();
            //Element
            CreateMap<Entities.Element, Element>();
            //Planet 
            CreateMap<Entities.Planet, Planet>();
        }
    }
}
