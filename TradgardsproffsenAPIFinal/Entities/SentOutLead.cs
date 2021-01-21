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
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string URL { get; set; }
        public string Info { get; set; }
        public List<JobDto> Jobbs { get; set; } = new List<JobDto>();
        public List<Company> CompaniesSentTo { get; set; } = new List<Company>();
    }
}
