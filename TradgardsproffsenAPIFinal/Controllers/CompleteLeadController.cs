using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("api/completelead")]
    [ApiController]
    public class CompleteLeadController : ControllerBase
    {
        private readonly ILeadsRepo _leadsRepo;
        private readonly IMapper _mapper;

        public CompleteLeadController(ILeadsRepo leadsRepo, IMapper mapper)
        {
            _leadsRepo = leadsRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CompletedLeadDto>> GetAllCompletedLeads()
        {
            var lostLeadFromRepo = _leadsRepo.GetAllLostLeads();
            return Ok(_mapper.Map<IEnumerable<CompletedLeadDto>>(lostLeadFromRepo));
        }
        [HttpGet("{id:int}", Name = "GetCompletedLeadById")]
        public ActionResult<CompletedLeadDto> GetCompletedLeadById(int id)
        {
            var lostLeadFromRepo = _leadsRepo.GetLostLeadById(id);
            if (lostLeadFromRepo != null)
            {
                return Ok(_mapper.Map<CompletedLeadDto>(lostLeadFromRepo));
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult<CompletedLeadDto> CompleteLead(CreateCompletedLeadDto lead)
        {
            var leadModel = _mapper.Map<CompletedLead>(lead);
            _leadsRepo.CompleteLead(leadModel);
            _leadsRepo.Save();


            var leadToReturn = _mapper.Map<CompletedLeadDto>(leadModel);
            return CreatedAtRoute("GetCompletedLeadById",
                new { Id = leadModel.Id }, leadToReturn);
        }
    }
}