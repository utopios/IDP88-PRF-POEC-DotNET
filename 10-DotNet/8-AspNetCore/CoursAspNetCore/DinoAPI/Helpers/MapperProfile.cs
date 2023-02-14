using AutoMapper;
using DinoAPI.DTOs;
using DinoAPI.Models;

namespace DinoAPI.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Dinosaur?, DinosaurDTO?>().ReverseMap();
        }
    }
}
