using AutoMapper;
using WebApplication3.DataTransferObjects;
using WebApplication3.Models;

namespace WebApplication3.MappingProfiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}
