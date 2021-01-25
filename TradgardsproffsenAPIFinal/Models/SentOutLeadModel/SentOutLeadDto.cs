using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;

namespace TradgardsproffsenAPI.Models
{
    public class SentOutLeadDto
    {
        public ValidatedLead Lead { get; set; }
        public List<LeadJob> Jobs { get; set; } = new List<LeadJob>();
        public List<Company> CompaniesSentTo { get; set; } = new List<Company>();
    }
}
