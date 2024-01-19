namespace NinjAPI.Models
{
    public class NinjaTraining
    {
        public Guid Id { get; set; }
        public virtual Ninja Ninja { get; set; }
        public Guid NinjaId { get; set; }
        public virtual Training Training { get; set; }
        public Guid TrainingId { get; set; }
    }
}
