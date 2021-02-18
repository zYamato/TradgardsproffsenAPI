using System;
using System.Collections.Generic;
using System.Linq;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.DbContexts;
using Microsoft.Extensions.Configuration;

namespace TradgardsproffsenAPI.Services
{
    public class LeadRepo : ILeadsRepo, IDisposable
    {
        private readonly TradgardsproffsenContext _context;
        private IConfiguration Configuration { get; }

        public LeadRepo(TradgardsproffsenContext context, IConfiguration configuration)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            this.Configuration = configuration;
        }

        //Company
        #region
        public IEnumerable<Company> GetAllCompanies()
        {
            return _context.Company.ToList()
                .OrderByDescending(o => o.County).ThenBy(o => o.Name);
        }
        public Company GetCompanyFromName(string name)
        {
            return _context.Company.Where(o => o.Name == name).FirstOrDefault();
        }
        public Company GetCompanyById(int id)
        {
            return _context.Company.Where(o => o.Id == id).FirstOrDefault();
        }
        public void AddCompany(Company company)
        {
            if(company == null)
            {
                throw new ArgumentNullException(nameof(company));
            }
            _context.Company.Add(company);
        }
        public void UpdateCompany(Company company)
        {
            //Nothing
        }
        public void DeleteCompany(Company company)
        {
            if(company == null)
            {
                throw new ArgumentNullException(nameof(company));
            }
            _context.Company.Remove(company);
        }
        #endregion
        //Leads
        #region
        public IEnumerable<Lead> GetLeads()
        {
            return _context.Lead.ToList()
                .OrderByDescending(o => o.Name);
        }
        public Lead GetLeadByName(string name)
        {
            return _context.Lead.Where(o => o.Name == name).FirstOrDefault();
        }
        public Lead GetLeadById(int id)
        {
            return _context.Lead.Where(o => o.Id == id).FirstOrDefault();
        }
        public void DeleteLead(Lead lead)
        {
            if (lead == null)
            {
                throw new ArgumentNullException(nameof(lead));
            }
            _context.Lead.Remove(lead);
        }
        public void ValidateLead(ValidatedLead ValidatedLead)
        {
            if(ValidatedLead == null)
            {
                throw new ArgumentNullException(nameof(ValidatedLead));
            }
            _context.ValidatedLead.Add(ValidatedLead);
        }
        #endregion
        //LostLeads
        #region
        public void LoseLead(LostLead lead)
        {
            if(lead == null)
            {
                throw new ArgumentNullException(nameof(lead));
            }
            _context.LostLead.Add(lead);
        }
        public IEnumerable<LostLead> GetAllLostLeads()
        {
            return _context.LostLead.ToList();
        }

        public LostLead GetLostLeadById(int id)
        {
            return _context.LostLead.Where(o => o.Id == id).FirstOrDefault();
        }
        #endregion
        //ValidatedLeads
        #region
        public IEnumerable<ValidatedLead> GetAllValidatedLeads()
        {
            return _context.ValidatedLead.ToList();
        }
        public ValidatedLead GetValidatedLeadsById(int id)
        {
            return _context.ValidatedLead.Where(o => o.Id == id).FirstOrDefault();
        }
        public void DeleteValidatedLead(ValidatedLead lead)
        {
            if (lead == null)
            {
                throw new ArgumentNullException(nameof(lead));
            }
            _context.ValidatedLead.Remove(lead);
        }
        public void SendLead(ValidatedLead lead, List<Company> Companies)
        {
            SentOutLead sentOutLead = new SentOutLead
            {
                Name = lead.Name,
                Email = lead.Email,
                PhoneNumber = lead.PhoneNumber,
                Address = lead.Address,
                District = lead.District,
                PostCode = lead.PostCode,
                Jobs = lead.Jobs,
                Info = lead.Info,
                URL = lead.URL,
                CompaniesSentTo = Companies
            };
            _context.ValidatedLead.Remove(lead);
            _context.SentOutLead.Add(sentOutLead);
        }

        #endregion
        //SentOut Lead
        #region

        public IEnumerable<SentOutLead> GetAllSentOutLeads()
        {
            return _context.SentOutLead.ToList()
                .OrderByDescending(o => o.Id);
        }


        #endregion
        //Jobs
        #region
        public IEnumerable<Job> GetAllJobs()
        {
            return _context.Job.ToList()
                .OrderBy(o => o.Name);
        }

        public Job GetJobById(int id)
        {
            return _context.Job.Where(o => o.Id == id).FirstOrDefault();
        }
        #endregion

        //LeadJob
        #region
        public IEnumerable<LeadJob> GetAllLeadJobs()
        {
            return _context.LeadJob.ToList();
        }
        #endregion

            public IEnumerable<Company> MatchingLead(ValidatedLead Lead)
            {
                List<Company> AcceptedForetag = new List<Company>(); 
                foreach(var foretag in _context.Company)
                {
                    for(int i = 0; i < foretag.AvailableJobs.Count; i++)
                    {
                        for(int j = 0; j < Lead.Jobs.Count; i++)
                        {
                            if (foretag.AvailableJobs[i].Job == Lead.Jobs[j].Job)
                            {
                                AcceptedForetag.Add(foretag);
                            }
                        }
                    }
                 }
                 AcceptedForetag.OrderByDescending(o => o.Accomplished % o.Left)
                     .ThenBy(o => o.HitRate);
        
                 return AcceptedForetag;
             }

        //Save and Dispose
        #region
        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }

        public void DeleteLeadJobs(int id)
        {
            IEnumerable<LeadJob> leadJobs = GetAllLeadJobs();

            foreach(var leadJob in leadJobs)
            {
                if(leadJob.ValidatedLeadId == id)
                {
                    _context.LeadJob.Remove(leadJob);
                }
            }
        }
        #endregion
    }
}
