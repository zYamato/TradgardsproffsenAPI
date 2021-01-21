using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class ValideradeLeadsProfile : Profile
    {
        public ValideradeLeadsProfile()
        {
            CreateMap<ValidatedLead, ValidatedLeadDto>();
            CreateMap<CreateValidatedLeadDto, ValidatedLead>();
        }
    }
}
