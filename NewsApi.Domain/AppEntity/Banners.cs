using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Domain.AppEntity
{
    public class Banners : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
    }
}
