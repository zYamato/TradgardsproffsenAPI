using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class LostLeadProfile : Profile
    {
        public LostLeadProfile()
        {
            CreateMap<LostLead, LostLeadDto>();
            CreateMap<CreateLostLeadDto, LostLead>();
        }
    }
}
