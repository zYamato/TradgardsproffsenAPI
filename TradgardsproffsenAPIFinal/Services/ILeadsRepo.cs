using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;

namespace TradgardsproffsenAPI.Services
{
    public interface ILeadsRepo
    {
        //Company
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

        #endregion

        //Validated Leads
        #region
        IEnumerable<ValidatedLead> GetAllValidatedLeads();
        ValidatedLead GetValidatedLeadsById(int id);
        void ValidateLead(ValidatedLead lead);
        void DeleteValidatedLead(ValidatedLead lead);

        #endregion

        //Lost Leads
        #region
        IEnumerable<LostLead> GetAllLostLeads();
        LostLead GetLostLeadById(int id);
        void LoseLead(LostLead Lead);
        #endregion

        //Sent Out Leads
        #region
        IEnumerable<SentOutLead> GetAllSentOutLeads();
        void SendLead(ValidatedLead Lead, List<Company> foretag);
        #endregion

        //Job
        #region
        IEnumerable<Job> GetAllJobs();

        Job GetJobById(int id);
        #endregion

        //LeadJob
        #region
        public IEnumerable<LeadJob> GetAllLeadJobs();
        #endregion

        bool Save();



    }
}
