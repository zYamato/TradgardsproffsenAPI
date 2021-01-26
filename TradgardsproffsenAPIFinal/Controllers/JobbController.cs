using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TradgardsproffsenAPI.Models;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("api/Jobb")]
    [ApiController]
    public class JobbController : ControllerBase
    {
         private readonly ILeadsRepo _leadsRepo;
         private readonly IMapper _mapper;

         public JobbController(ILeadsRepo leadsRepo, IMapper mapper)
         {
             _leadsRepo = leadsRepo;
             _mapper = mapper;
         }

        [HttpGet]
         public ActionResult<IEnumerable<Jobs>> GetAllForetag()
         {
             var jobbFromRepo = _leadsRepo.GetAllJobs();
             return Ok(_mapper.Map<IEnumerable<Jobs>>(jobbFromRepo));
         }
    }
}

