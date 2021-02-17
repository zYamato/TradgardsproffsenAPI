using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("api/lostlead")]
    [ApiController]
    public class LostLeadController : ControllerBase
    {
        private readonly ILeadsRepo _leadsRepo;
        private readonly IMapper _mapper;

        public LostLeadController(ILeadsRepo leadsRepo, IMapper mapper)
        {
            _leadsRepo = leadsRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LostLeadDto>> GetAllLostLeads()
        {
            var lostLeadFromRepo = _leadsRepo.GetAllLostLeads();
            return Ok(_mapper.Map<IEnumerable<LostLeadDto>>(lostLeadFromRepo));
        }
        [HttpGet("{id:int}", Name = "GetLostLeadById")]
        public ActionResult<LostLeadDto> GetLostLeadById(int id)
        {
            var lostLeadFromRepo = _leadsRepo.GetLostLeadById(id);
            if (lostLeadFromRepo != null)
            {
                return Ok(_mapper.Map<ValidatedLeadDto>(lostLeadFromRepo));
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult<LostLeadDto> LoseLead(CreateLostLeadDto lead)
        {
            var leadModel = _mapper.Map<LostLead>(lead);
            _leadsRepo.LoseLead(leadModel);
            _leadsRepo.Save();


            var leadToReturn = _mapper.Map<LostLeadDto>(leadModel);
            return CreatedAtRoute("GetLostLeadById",
                new { Id = leadModel.Id }, leadToReturn);
        }
    }
}
