namespace Equb.Dtos
{
    public class EqubCreateDto
    {
        public string? EqubName { get; set; }
        public int? AdminId { get; set; }
        public int? FrequencyDays { get; set; }
        public int? Price { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
