using AutoMapper;
using Vidly.DataTransferObjects;
using Vidly.Models;

namespace Vidly.MappingProfiles
{
    public class MembershipTypeProfile : Profile
    {
        public MembershipTypeProfile()
        {
            CreateMap<MembershipType, MembershipTypeDto>();
        }
    }
}
