using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Domain.Dtos.NewsDto
{
    class WriteNews
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Auther { get; set; }
        public string Desc { get; set; }
    }
}
