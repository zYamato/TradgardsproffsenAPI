using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class ForloradeLeadsProfile : Profile
    {
        public ForloradeLeadsProfile()
        {
            CreateMap<LostLead, LostLeadDto>();
        }
    }
}
