using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class JobbProfile : Profile
    {
        public JobbProfile()
        {
            CreateMap<Job, JobDto>();
        }
    }
}
