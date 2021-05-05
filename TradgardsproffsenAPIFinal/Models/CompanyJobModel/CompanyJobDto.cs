using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradgardsproffsenAPI.Models
{
    public class CompanyJobDto
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int JobId { get; set; }
    }
}
