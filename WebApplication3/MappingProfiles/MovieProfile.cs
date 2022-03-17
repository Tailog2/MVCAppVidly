using AutoMapper;
using Vidly.DataTransferObjects;
using Vidly.Models;

namespace Vidly.MappingProfiles
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
