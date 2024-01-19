using System.ComponentModel.DataAnnotations.Schema;

namespace NinjAPI.Models
{
    public class Ninja
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public DateOnly ? DateOfBirth { get; set; }
        public NinjaSpecialization Specialization { get; set; }
        public virtual ICollection<NinjaTraining> NinjaTraining { get; set; } = Array.Empty<NinjaTraining>();
    }

    public enum NinjaSpecialization
    {
        None = 0,
        SwordFighting = 1,
        Stealth = 2,
        ShurikenThrowing = 3
    }
}