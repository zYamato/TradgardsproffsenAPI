using System;
using System.Collections.Generic;
using System.Linq;
using TradgardsproffsenAPI.Entities;
using TradgardsproffsenAPI.DbContexts;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

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
        #endregion
        //SentOutLead
        #region

        public IEnumerable<SentOutLead> GetAllSentOutLeads()
        {
            return _context.SentOutLead.ToList()
                .OrderByDescending(o => o.Id);
        }

        public SentOutLead GetSentOutLeadById(int id)
        {
            return _context.SentOutLead.Where(o => o.Id == id).FirstOrDefault();
        }
        public void SendLead(SentOutLead lead)
        {
            if (lead == null)
            {
                throw new ArgumentNullException(nameof(lead));
            }
            _context.SentOutLead.Add(lead);
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
        public void DeleteLeadJobs(int id)
        {
            IEnumerable<LeadJob> leadJobs = GetAllLeadJobs();

            foreach (var leadJob in leadJobs)
            {
                if (leadJob.ValidatedLeadId == id)
                {
                    _context.LeadJob.Remove(leadJob);
                }
            }
        }
        #endregion
        //User
        #region
        public void AddUser(User user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            _context.Users.Add(user);
        }
        public void DeleteUser(User user)
        {
            if(user == null) throw new ArgumentNullException(nameof(user));

            _context.Users.Remove(user);
        }
        public User GetUser(string Username)
        {
            if (Username == null) throw new ArgumentNullException(nameof(Username));

            return _context.Users.FirstOrDefault(a => a.Username == Username);
        }
        public User GetUser(int userId)
        {
            return _context.Users.FirstOrDefault(a => a.Id == userId);
        }
        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList<User>();
        }
        public bool UserExists(int userId)
        {
            if(userId <= 0)
            {
                throw new ArgumentNullException(nameof(userId));
            }
            return _context.Users.Any(a => a.Id == userId);
        }
        #endregion

        public IEnumerable<Company> MatchingLead(ValidatedLead Lead)
            {
                List<Company> AcceptedCompany = new List<Company>(); 
                foreach(var company in _context.Company)
                {
                    for(int i = 0; i < company.AvailableJobs.Count; i++)
                    {
                        for(int j = 0; j < Lead.Jobs.Count; i++)
                        {
                            if (company.AvailableJobs[i].Job == Lead.Jobs[j].Job)
                            {
                                AcceptedCompany.Add(company);
                            }
                        }
                    }
                 }
                 AcceptedCompany.OrderByDescending(o => o.Accomplished / o.Left)
                     .ThenBy(o => o.HitRate);
        
                 return AcceptedCompany;
             }

        //Save and Dispose
        #region

        public JwtSecurityToken AuthenticateUser(string name, string password)
        {
            var user = _context.Users.Where(a => a.Username == name && a.Password == password).FirstOrDefault();
            if (user == null) return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(Configuration["JWT:Secret"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, name)
                }),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateJwtSecurityToken(tokenDescriptor);

            return token;
        }

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
        #endregion
    }
}
