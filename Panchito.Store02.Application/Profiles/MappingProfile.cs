using AutoMapper;
using Panchito.Store02.Application.Dtos;
using Panchito.Store02.Entity;

namespace Panchito.Store02.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}
