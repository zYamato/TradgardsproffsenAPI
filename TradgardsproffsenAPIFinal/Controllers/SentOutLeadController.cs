﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("api/sentoutleads")]
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

        [HttpPost]
        public ActionResult<SentOutLeadDto> SendLead(CreateSentOutLeadDto sentOutLead)
        {
            var leadModel = _mapper.Map<SentOutLead>(sentOutLead);
            _leadsRepo.SendLead(leadModel);
            _leadsRepo.Save();
        
            var leadToReturn = _mapper.Map<SentOutLeadDto>(leadModel);
            return CreatedAtRoute("GetSentOutLeadById",
                    new { Id = leadModel.Id }, leadToReturn);
        }

        [HttpGet("{id:int}", Name = "GetSentOutLeadById")]
        public ActionResult<SentOutLeadDto> GetSentOutLeadById(int id)
        {
            var sentOutLeadFromRepo = _leadsRepo.GetSentOutLeadById(id);
            if (sentOutLeadFromRepo != null)
            {
                return Ok(_mapper.Map<SentOutLeadDto>(sentOutLeadFromRepo));
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteSentOutLead(int id)
        {
            var leadFromRepo = _leadsRepo.GetSentOutLeadById(id);
            if (leadFromRepo == null)
            {
                return NotFound();
            }
            _leadsRepo.DeleteSentOutLeadJobs(id);
            _leadsRepo.DeleteSentOutLead(leadFromRepo);
            _leadsRepo.Save();

            return NoContent();
        }
    }
}
