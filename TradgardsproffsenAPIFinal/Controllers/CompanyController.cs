using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;
using TradgardsproffsenAPI.Services;

namespace TradgardsproffsenAPI.Controllers
{
    [Route("api/company")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ILeadsRepo _leadsRepo;
        private readonly IMapper _mapper;

        public CompanyController(ILeadsRepo leadsRepo, IMapper mapper)
        {
            _leadsRepo = leadsRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<CompanyDto>> GetAllCompanies()
        {
            var companiesFromRepo = _leadsRepo.GetAllCompanies();
            return Ok(_mapper.Map<IEnumerable<CompanyDto>>(companiesFromRepo));
        }

        [HttpGet("{id:int}", Name="GetCompanyById")]
        public ActionResult <CompanyDto> GetCompanyById(int id)
        {
            var companyFromRepo = _leadsRepo.GetCompanyById(id);
            if(companyFromRepo != null)
            {
                return Ok(_mapper.Map<CompanyDto>(companyFromRepo));
            }
            return NotFound(); 
        }

        [HttpGet("{name}")]
        public ActionResult <CompanyDto> GetCompanyByName(string name)
        {
            var companyFromRepo = _leadsRepo.GetCompanyFromName(name);
            if(companyFromRepo != null)
            {
                return Ok(_mapper.Map<CompanyDto>(companyFromRepo));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<CompanyDto> AddCompany(CreateCompanyDto company)
        {
            var companyModel = _mapper.Map<Company>(company);
            _leadsRepo.AddCompany(companyModel);
            _leadsRepo.Save();

            var companyToReturn = _mapper.Map<CompanyDto>(companyModel);
            return CreatedAtRoute("GetCompanyById",
                new { Id = companyModel.Id }, companyToReturn);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCompany(int id, UpdateCompanyDto company)
        {
            var companyFromRepo = _leadsRepo.GetCompanyById(id);
            if(companyFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(company, companyFromRepo);
            _leadsRepo.UpdateCompany(companyFromRepo);
            _leadsRepo.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCompany(int id)
        {
            var companyFromRepo = _leadsRepo.GetCompanyById(id);
            if (companyFromRepo == null)
            {
                return NotFound();
            }
            _leadsRepo.DeleteCompany(companyFromRepo);
            _leadsRepo.Save();

            return NoContent();
        }

    //   [Route("Match")]
    //   [HttpGet]
    //   public ActionResult<IEnumerable<ForetagReadDto>> MatchingLead(ValideradeLeads Leads)
    //   {
    //       var listOfMatchingForetag = _leadsRepo.MatchingLead(Leads);
    //       if (listOfMatchingForetag == null)
    //       {
    //           return NotFound();
    //       }
    //
    //       return Ok(_mapper.Map<IEnumerable<ForetagReadDto>>(listOfMatchingForetag));
    //   }
    }
}
