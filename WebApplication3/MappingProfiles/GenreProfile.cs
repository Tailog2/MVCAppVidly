using AutoMapper;
using Vidly.DataTransferObjects;
using Vidly.Models;

namespace Vidly.MappingProfiles
{
    public class GenreProfile : Profile
    {
        public GenreProfile()
        {
            CreateMap<Genre, GenreDto>();
        }  
    }
}
