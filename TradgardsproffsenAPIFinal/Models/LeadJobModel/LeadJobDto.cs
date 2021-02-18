using TradgardsproffsenAPI.Entities;
namespace TradgardsproffsenAPI.Models.LeadJobModel
{
    public class LeadJobDto
    {
        public int? ValidatedLeadId { get; set; }
        public int? SentOutLeadId { get; set; }
        public int JobId { get; set; }
    }
}
