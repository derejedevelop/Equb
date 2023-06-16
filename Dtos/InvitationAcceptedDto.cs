namespace Equb.Dtos
{
    public class InvitationAcceptedDto
    {
        public int MemberInviteId { get; set; }
        public bool? Accepted { get; set; }
        public DateTime? ReplyDate { get; set; }
    }
}
