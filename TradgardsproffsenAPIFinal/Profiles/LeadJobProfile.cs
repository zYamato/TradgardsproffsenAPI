using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
