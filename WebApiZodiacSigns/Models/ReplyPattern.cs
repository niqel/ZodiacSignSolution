using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiZodiacSigns.Models
{
    public class ReplyPattern<TEntity> where TEntity : class
    {
        public bool IsSucess { get; set; }
        public string Message { get; set; }
        public int TotalCount { get; set; }
        public TEntity Data { get; set; }
    }
}
