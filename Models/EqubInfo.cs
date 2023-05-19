namespace Equb.Models
{
    public class EqubInfo
    {
        public int EqubInfoId { get; set; }
        public string? EqubName { get; set; }
        public int? AdminId { get; set; }
        public int? FrequencyDays { get; set; }
        public int? Price { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Today;
        public DateTime? StartDate { get; set;}
        public DateTime? EndDate { get; set; } = null;
    }
}
