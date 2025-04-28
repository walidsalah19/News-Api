using AutoMapper;
using NewsApi.Domain.AppEntity;
using NewsApi.Domain.Dtos.BannerDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.handler.Mapper
{
   public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Banners, ReadBanner>();
            CreateMap<WriteBanner, Banners>();

        }
    }
}
