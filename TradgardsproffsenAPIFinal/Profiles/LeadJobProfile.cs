using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models.LeadJobModel;

namespace TradgardsproffsenAPI.Profiles
{
    public class LeadJobProfile : Profile
    {
        public LeadJobProfile()
        {
            CreateMap<LeadJob, LeadJobDto>();
        }
    }
}
