﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("/api/leadjobs")]
    [ApiController]
    public class LeadJobsController : ControllerBase
    {
        private readonly ILeadsRepo _leadsRepo;
        private readonly IMapper _mapper;

        public LeadJobsController(ILeadsRepo leadsRepo, IMapper mapper)
        {
            _leadsRepo = leadsRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LeadJob>> GetAllLeadJobs()
        {
            var leadJobsFromRepo = _leadsRepo.GetAllLeadJobs();
            return Ok(_mapper.Map<IEnumerable<LeadJob>>(leadJobsFromRepo));
        }


    }
}
