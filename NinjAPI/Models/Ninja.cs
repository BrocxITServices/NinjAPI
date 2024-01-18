using System.ComponentModel.DataAnnotations.Schema;

namespace NinjAPI.Models
{
    public class Ninja
    {
        public Guid NinjaId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public NinjaSpecialization Specialization { get; set; }

        //Navigation property | Each Ninja has access to multiple trainings
        public ICollection<Training>? Trainings { get; set; }
    }
    public enum NinjaSpecialization
    {
        None = 0,
        SwordFighting = 1,
        Stealth = 2,
        ShurikenThrowing = 3
    }
}