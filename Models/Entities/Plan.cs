namespace gym.Models.Entities
{
    public class Plan:BaseMember
    {
        public string Name { get; set; }=default!;
        public string Description { get; set; }=default!;
        public decimal Price { get; set; }=default!;
        
        public int DurationDays { get; set; }

        public bool IsActive { get; set; }

        public ICollection<MemberPlan> MemberPlans { get; set; }
    = new List<MemberPlan>();
    }
}
