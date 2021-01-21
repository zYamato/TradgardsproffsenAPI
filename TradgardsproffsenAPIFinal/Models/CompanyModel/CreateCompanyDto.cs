using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TradgardsproffsenAPI.Entities;

namespace TradgardsproffsenAPI.Models
{
    public class CreateCompanyDto
    {
        [Required]
        public string Namn { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string TelefonNummer { get; set; }
        [Required]
        public double Omsattningsmal { get; set; }
        public int Fakturerat { get; set; } = 0;
        [Required]
        public double Kvar { get; set; }
        [Required]
        public string Lan { get; set; }
        public DateTimeOffset? SenasteLead { get; set; } = null;
        public int Utförda { get; set; } = 0;
        public double Hitrate { get; set; } = 0;

        [Required]
        public List<CompanyJob> TillgangligaJobb { get; set; } = new List<CompanyJob>();

    }
}
