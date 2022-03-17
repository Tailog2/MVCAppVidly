using AutoMapper;
using Vidly.DataTransferObjects;
using Vidly.Models;

namespace Vidly
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}
