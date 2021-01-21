using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class AllLeadProfile : Profile
    {
        public AllLeadProfile()
        {
            CreateMap<AllLead, AllLeadDto>();
        }
    }
}
