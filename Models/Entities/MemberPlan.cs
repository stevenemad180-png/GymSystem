using System.ComponentModel.DataAnnotations.Schema;

namespace gym.Models.Entities
{
    public class MemberPlan: BaseMember
    {
        public int MemberId { get; set; }
        public Member Member { get; set;}
        public int PlanId { get; set; }
        public Plan Plan { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [NotMapped]
        public string status => StartDate > DateTime.Now ? "upcomimg"
                                    : EndDate > DateTime.Now ? "Acive"
                                     : "Expired";
    }

}
