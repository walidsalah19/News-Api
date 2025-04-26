using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Domain.Dtos.NewsDto
{
    class ReadNews
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Auther { get; set; }
        public string Desc { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
