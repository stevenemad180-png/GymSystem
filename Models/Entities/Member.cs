using gym.Models.Enums;

namespace gym.Models.Entities
{
    public class Member:person
    {
      

        public string? photo { get; set; }

        public ICollection<MemberPlan> MemberPlans { get; set; }
            = new List<MemberPlan>();




    }
}
