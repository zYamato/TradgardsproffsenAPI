﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TradgardsproffsenAPI.Models;

namespace TradgardsproffsenAPI.Models
{
    public class CreateValidatedLeadDto
    {
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

        public string URL { get; set; }

        [Required]
        public string Info { get; set; }
        public List<JobDto> Jobs { get; set; } = new List<JobDto>();
    }
}
