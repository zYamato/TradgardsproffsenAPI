using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class AllaLeadsProfile : Profile
    {
        public AllaLeadsProfile()
        {
            CreateMap<AllLead, AllLeadDto>();
        }
    }
}
