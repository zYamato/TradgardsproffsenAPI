using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;
using TradgardsproffsenAPI.Models.LeadJobModel;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("/api/companyjobs")]
    [ApiController]
    public class CompanyJobsController : ControllerBase
    {
        private readonly ILeadsRepo _leadsRepo;
        private readonly IMapper _mapper;

        public CompanyJobsController(ILeadsRepo leadsRepo, IMapper mapper)
        {
            _leadsRepo = leadsRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CompanyJobDto>> GetAllCompanyJobs()
        {
            var companyJobsFromRepo = _leadsRepo.GetAllCompanyJobs();
            return Ok(_mapper.Map<IEnumerable<CompanyJobDto>>(companyJobsFromRepo));
        }
    }
}