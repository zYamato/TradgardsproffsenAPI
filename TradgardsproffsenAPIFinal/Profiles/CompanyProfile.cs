using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDto>();
            CreateMap<CreateCompanyDto, Company>();
            CreateMap<UpdateCompanyDto, Company>();
        }
    }
}
