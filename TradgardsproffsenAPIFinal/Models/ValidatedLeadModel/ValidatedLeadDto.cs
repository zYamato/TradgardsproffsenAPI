using System.Collections.Generic;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Models
{
    public class ValidatedLeadDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string District { get; set; }
        public string Email { get; set; }
        public string URL { get; set; }
        public string Info { get; set; }
        public List<JobDto> Jobs { get; set; } = new List<JobDto>();
    }
}
