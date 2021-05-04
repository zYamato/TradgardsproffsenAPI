﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TradgardsproffsenAPI.Entities
{
    public class CompletedLead
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string URL { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
        public List<LeadJob> Jobs { get; set; }
        public List<Company> CompaniesSentTo { get; set; }
    }
}
