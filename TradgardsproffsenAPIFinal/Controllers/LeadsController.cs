using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TradgardsproffsenAPI.Models;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("api/leads")]
    public class LeadsController : ControllerBase
    {
        private readonly ILeadsRepo _leadsRepo;
        private readonly IMapper _mapper;

        public LeadsController(ILeadsRepo leadsRepo, IMapper mapper)
        {
            _leadsRepo = leadsRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LeadDto>> GetAllLeads()
        {
            var leadsFromRepo = _leadsRepo.GetLeads();
            if (leadsFromRepo == null) return NotFound();

            return Ok(_mapper.Map<IEnumerable<LeadDto>>(leadsFromRepo));
        }
        [HttpGet("{id:int}", Name="GetLeadById")]
        public ActionResult <LeadDto> GetLeadById(int id)
        {
            var leadFromRepo = _leadsRepo.GetLeadById(id);
            if(leadFromRepo != null)
            {
                return Ok(_mapper.Map<LeadDto>(leadFromRepo));
            }
            return NotFound();
        }  
        [HttpGet("{name}")]
        public ActionResult<LeadDto> GetLeadByName(string name)
        {
            var leadFromRepo = _leadsRepo.GetLeadByName(name);
            if(leadFromRepo != null)
            {
                return Ok(_mapper.Map<LeadDto>(leadFromRepo));
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteLead(int id)
        {
            var LeadFromRepo = _leadsRepo.GetLeadById(id);
            if (LeadFromRepo == null)
            {
                return NotFound();
            }
            _leadsRepo.DeleteLead(LeadFromRepo);
            _leadsRepo.Save();

            return NoContent();
        }
    }
}
