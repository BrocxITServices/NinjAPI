using System.ComponentModel.DataAnnotations.Schema;

namespace NinjAPI.Models
{
    public class Ninja : BaseEntity
    {
        public string Name { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public NinjaSpecialization Specialization { get; set; }
        [ForeignKey(nameof(Training))]
        public List<Training> Trainings { get; set; }
    }

    public enum NinjaSpecialization
    {
        None = 0,
        SwordFighting = 1
    }
}
