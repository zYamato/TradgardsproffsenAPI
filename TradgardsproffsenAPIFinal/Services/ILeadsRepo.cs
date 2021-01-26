using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Services
{
    public interface ILeadsRepo
    {
        //Företag
        #region
        IEnumerable<Company> GetAllCompanies();
        Company GetCompanyFromName(string name);
        Company GetCompanyById(int id);
        void AddCompany(Company foretag);
        void UpdateCompany(Company foretag);
        void DeleteCompany(Company foretag);
       // IEnumerable<Foretag> MatchingLead(ValideradeLeads Lead);
        #endregion

        //Leads
        #region
        IEnumerable<Lead> GetLeads();
        Lead GetLeadByName(string name);
        Lead GetLeadById(int id);
        void DeleteLead(Lead lead);
        void ValidateLead(ValidatedLead lead);

        #endregion

        //Validerade Leads
        #region
        IEnumerable<ValidatedLead> GetAllValidatedLeads();
        ValidatedLead GetValidatedLeadsById(int id);

        #endregion

        //FörloradeLeads
        #region
        IEnumerable<LostLead> GetAllLostLeads();
        void LoseLead(Lead Lead);
        #endregion

        //Utskickade Leads
        #region
        IEnumerable<SentOutLead> GetAllSentOutLeads();
        void SendLead(ValidatedLead Lead, List<Company> foretag);
        #endregion

        //Jobb
        #region
        IEnumerable<Job> GetAllJobs();
        #endregion

        //LeadJob
        #region
        public IEnumerable<LeadJob> GetAllLeadJobs();
        #endregion

        bool Save();



    }
}
