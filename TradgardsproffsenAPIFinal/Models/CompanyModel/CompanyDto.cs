using System;
using System.Collections.Generic;
using TradgardsproffsenAPI.Entities;

namespace TradgardsproffsenAPI.Models
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public string Mail { get; set; }
        public string TelefonNummer { get; set; }
        public double Omsattningsmal { get; set; }
        public int Fakturerat { get; set; }
        public double Kvar { get; set; }
        public DateTimeOffset? SenasteLead { get; set; }
        public string Lan { get; set; }
        public int Utförda { get; set; }
        public double Hitrate { get; set; }
        public List<ValidatedLead> Leads { get; set; }
        public List<CompanyJob> TillgangligaJobb { get; set; } = new List<CompanyJob>();

    }
}