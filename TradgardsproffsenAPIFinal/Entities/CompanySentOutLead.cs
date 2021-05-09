using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradgardsproffsenAPI.Entities
{
    public class CompanySentOutLead
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int SentOutLeadId { get; set; }
        public int CompanyId { get; set; }
    }
}
