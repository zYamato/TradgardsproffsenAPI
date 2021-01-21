using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;

namespace TradgardsproffsenAPI.Models
{
    public class SentOutLeadDto
    {
        public ValidatedLead Lead { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PostNr { get; set; }
        public string Info { get; set; }
        public List<LeadJob> Jobs { get; set; } = new List<LeadJob>();
        public List<Company> ForetagListaSkickade { get; set; } = new List<Company>();
    }
}
