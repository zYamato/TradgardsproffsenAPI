using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("api/validatedleads")]
    public class ValidatedLeadsController : ControllerBase
    {
        private readonly ILeadsRepo _leadsRepo;
        private readonly IMapper _mapper;

        public ValidatedLeadsController(ILeadsRepo leadsRepo, IMapper mapper)
        {
            _leadsRepo = leadsRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<ValidatedLeadDto>> GetAllValidatedLeads()
        {
            var validatedLeadFromRepo = _leadsRepo.GetAllValidatedLeads();
            if(validatedLeadFromRepo != null)
            {
                return Ok(_mapper.Map<IEnumerable<ValidatedLeadDto>>(validatedLeadFromRepo));
            }
            return NotFound();
        }

        [HttpGet("{id:int}", Name="GetValidatedLeadById")]
        public ActionResult<ValidatedLeadDto> GetValidatedLeadById(int id)
        {
            var validatedLeadFromRepo = _leadsRepo.GetValidatedLeadsById(id);
            if(validatedLeadFromRepo != null)
            {
                return Ok(_mapper.Map<ValidatedLeadDto>(validatedLeadFromRepo));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<ValidatedLeadDto> ValideraLead([FromBody]CreateValidatedLeadDto lead)
        {
            var leadModel = _mapper.Map<ValidatedLead>(lead);
            _leadsRepo.ValidateLead(leadModel);
            _leadsRepo.Save();


            var leadToReturn = _mapper.Map<ValidatedLeadDto>(leadModel);
            return CreatedAtRoute("GetValidatedLeadById",
                new { Id = leadModel.Id }, leadToReturn);
        }
    }
}
