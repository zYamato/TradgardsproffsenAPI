using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradgardsproffsenAPI.Entities;

namespace TradgardsproffsenAPI.DbContexts
{
    public class TradgardsproffsenContext : DbContext
    {
        public TradgardsproffsenContext(DbContextOptions<TradgardsproffsenContext> options) : base(options) { }

        public DbSet<Company> Company { get; set; }
        public DbSet<Lead> Lead { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<LeadJob> LeadJob { get; set; }
        public DbSet<CompanyJob> CompanyJob { get; set; }
        public DbSet<ValidatedLead> ValidatedLead { get; set; }
        public DbSet<LostLead> LostLead { get; set; }
        public DbSet<SentOutLead> SentOutLead { get; set; }
    }
}
