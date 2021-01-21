using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TradgardsproffsenAPI.Models;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("api/AllLead")]
    [ApiController]
    public class AllaLeadsController : ControllerBase
    {
        private readonly ILeadsRepo _leadsRepo;
        private readonly IMapper _mapper;

        public AllaLeadsController(ILeadsRepo leadsRepo, IMapper mapper)
        {
            _leadsRepo = leadsRepo;
            _mapper = mapper;
        }

        public ActionResult<IEnumerable<AllLeadDto>> GetAllLeads()
        {
            var leadsFromRepo = _leadsRepo.GetAllLeads();
            return Ok(_mapper.Map<IEnumerable<AllLeadDto>>(leadsFromRepo));
        }
    }
}
