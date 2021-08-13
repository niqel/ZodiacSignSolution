using ApiZodiacSigns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiZodiacSigns.IApis
{
    public interface IFinder<TEntity> where TEntity : class
    {
        public Reply<TEntity> GetAll();
        public Reply<TEntity> GetById(int id);
    }
}
