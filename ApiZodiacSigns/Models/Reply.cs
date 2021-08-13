using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiZodiacSigns.Models
{
    public class Reply<TEntity> where TEntity : class
    {
        public bool IsSucess { get; set; }
        public string Message { get; set; }
        public int TotalCount { get; set; }
        public virtual List<TEntity> Items { get; set; }
        public virtual List<Error> Errors { get; set; }
    }
}
