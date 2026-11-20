using gym.Models.Enums;

namespace gym.Models.Entities
{
    public class trainer:person
    {
        public Speciality Speciality { get; set; }

        public ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
