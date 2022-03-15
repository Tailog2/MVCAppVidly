using AutoMapper;
using WebApplication3.DataTransferObjects;
using WebApplication3.Models;

namespace WebApplication3.MappingProfiles
{
    public class GenreProfile : Profile
    {
        public GenreProfile()
        {
            CreateMap<Genre, GenreDto>();
        }  
    }
}
