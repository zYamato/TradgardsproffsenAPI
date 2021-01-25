using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Entities
{
    public class SentOutLead
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public ValidatedLead Lead { get; set; }
        public List<LeadJob> Jobs { get; set; } = new List<LeadJob>();
        public List<Company> CompaniesSentTo { get; set; } = new List<Company>();
    }
}
