using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class SentOutLeadProfile : Profile
    {
        public SentOutLeadProfile()
        {
            CreateMap<SentOutLead, SentOutLeadDto>();
            CreateMap<CreateSentOutLeadDto, SentOutLead>();
        }
    }
}
