using System;
using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class CompletedLeadProfile : Profile
    {
        public CompletedLeadProfile()
        {
            CreateMap<CompletedLead, CompletedLeadDto>();
            CreateMap<CreateCompletedLeadDto, CompletedLead>();
        }
    }
}
