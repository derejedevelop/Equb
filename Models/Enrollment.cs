namespace Equb.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int? EqubId { get; set; }
        public int? UserId { get; set; }
        public bool? Cancelled { get; set; } = false;
        public DateTime? EnrollmentDate { get; set; } = DateTime.Today;
        public DateTime? EndDate { get; set; } = null;
    }
}
