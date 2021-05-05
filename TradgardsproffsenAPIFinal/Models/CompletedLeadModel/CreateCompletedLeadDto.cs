using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradgardsproffsenAPI.Entities;

namespace TradgardsproffsenAPI.Models
{
    public class CreateCompletedLeadDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
        public List<LeadJob> Jobs { get; set; }
        public List<Company> CompaniesSentTo { get; set; }
        public Company CompanyCompleted { get; set; }
    }
}
