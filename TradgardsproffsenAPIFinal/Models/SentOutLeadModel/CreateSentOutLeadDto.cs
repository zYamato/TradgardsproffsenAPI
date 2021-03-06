﻿using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;

namespace TradgardsproffsenAPI.Models
{
    public class CreateSentOutLeadDto
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
        public List<CompanySentOutLead> CompaniesSentTo { get; set; }
    }
}
