using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class LeadProfile : Profile
    {
        public LeadProfile()
        {
            CreateMap<Lead, LeadDto>();
        }
    }
}
