namespace Equb.Models
{
    public class Users
    {
        public int UsersId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; } = null;
        public string? Password { get; set; }
        public DateTime? SignUpDate { get; set; } = DateTime.Today;
    }
}
