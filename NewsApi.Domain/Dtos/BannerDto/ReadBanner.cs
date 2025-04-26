using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Domain.Dtos.BannerDto
{
    public class ReadBanner
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
