using AutoMapper;
using WebApplication3.DataTransferObjects;
using WebApplication3.Models;

namespace WebApplication3
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
