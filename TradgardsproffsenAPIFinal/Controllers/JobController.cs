using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TradgardsproffsenAPI.Models;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("api/job")]
    [ApiController]
    public class JobController : ControllerBase
    {
         private readonly ILeadsRepo _leadsRepo;
         private readonly IMapper _mapper;

         public JobController(ILeadsRepo leadsRepo, IMapper mapper)
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

