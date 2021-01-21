using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class LeadsProfile : Profile
    {
        public LeadsProfile()
        {
            CreateMap<Lead, LeadDto>();
        }
    }
}
