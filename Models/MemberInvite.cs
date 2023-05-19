namespace Equb.Models
{
    public class MemberInvite
    {
        public int MemberInviteId { get; set; }
        public int? EqubId { get; set; }
        public int? InviterUserId { get; set; }
        public int? InviteeUserId { get; set; }
        public bool? Accepted { get; set; } = false;
        public bool? Declined { get; set; } = false;
        public DateTime? InviteDate { get; set; } = DateTime.Today;
        public DateTime? ReplyDate { get; set; } = null;
    }
}
