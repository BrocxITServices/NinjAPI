using System.ComponentModel.DataAnnotations.Schema;

namespace NinjAPI.Models
{
    public class Ninja
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public NinjaSpecialization Specialization { get; set; }
        public Training? Training { get; set; }
    }

    public enum NinjaSpecialization
    {
        None = 0,
        SwordFighting = 1,
        Stealth = 2,
        ShurikenThrowing = 3
    }
}