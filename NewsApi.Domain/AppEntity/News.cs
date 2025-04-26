using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Domain.AppEntity
{
   public class News : BaseEntity
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Auther { get; set; }
        public string Desc { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
