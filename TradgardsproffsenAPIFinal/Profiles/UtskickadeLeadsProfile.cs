using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class UtskickadeLeadsProfile : Profile
    {
        public UtskickadeLeadsProfile()
        {
            CreateMap<SentOutLead, SentOutLeadDto>();
            CreateMap<CreateSentOutLeadDto, SentOutLead>();
        }
    }
}
