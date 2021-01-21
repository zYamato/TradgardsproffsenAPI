using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TradgardsproffsenAPI.Models;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("api/LostLead")]
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
            var forloratLeadsFromRepo = _leadsRepo.GetAllLostLeads();
            return Ok(_mapper.Map<IEnumerable<LostLeadDto>>(forloratLeadsFromRepo));
        }

    }
}
