using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;

namespace TradgardsproffsenAPI.Models
{
    public class CreareSentOutLeadDto
    {
        public ValidatedLead Lead { get; set; }
        public List<LeadJob> Jobbs { get; set; } = new List<LeadJob>();
        public List<Company> ForetagListaSkickade { get; set; } = new List<Company>();
    }
}
