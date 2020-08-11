using AutoMapper;
using proj.Dtos;
using proj.Models;

namespace proj.Profiles
{
    public class DetailsProfile : Profile
    {
        public DetailsProfile()
        {
            CreateMap<Detail, DetailReadDto>();
        }
    }
}