using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class CompanyJobProfile : Profile
    {
        public CompanyJobProfile()
        {
            CreateMap<CompanyJob, CompanyJobDto>();
        }
    }
}
