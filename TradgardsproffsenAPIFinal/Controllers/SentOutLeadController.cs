﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("apu/sentoutlead")]
    [ApiController]
    public class SentOutLeadController : ControllerBase
    {
        private readonly ILeadsRepo _leadsRepo;
        private readonly IMapper _mapper;

        public SentOutLeadController(ILeadsRepo leadsRepo, IMapper mapper)
        {
            _leadsRepo = leadsRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SentOutLeadDto>> GetAllSentOutLeads()
        {
            var sentOutLeadFromRepo = _leadsRepo.GetAllSentOutLeads();
            if (sentOutLeadFromRepo != null)
            {
                return Ok(_mapper.Map<IEnumerable<SentOutLeadDto>>(sentOutLeadFromRepo));
            }
            return NotFound();
        }

        //[HttpPost]
        //public ActionResult<SentOutLeadDto> SendLead(CreateSentOutLeadDto sentOutLead)
        //{
        //    var leadModel = _mapper.Map<ValidatedLead>(sentOutLead);
        //    _leadsRepo.SendLead(leadModel);
        //    _leadsRepo.Save();
        //
        //    var leadToReturn = _mapper.Map<SentOutLeadDto>(leadModel);
        //    return CreatedAtRoute("GetValidatedLeadById",
        //            new { Id = leadModel.Id }, leadToReturn);
        //}
    }
}