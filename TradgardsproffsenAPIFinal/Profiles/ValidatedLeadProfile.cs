﻿using AutoMapper;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Profiles
{
    public class ValidatedLeadProfile : Profile
    {
        public ValidatedLeadProfile()
        {
            CreateMap<CreateValidatedLeadDto, ValidatedLead>();
            CreateMap<ValidatedLead, ValidatedLeadDto>();

        }
    }
}
