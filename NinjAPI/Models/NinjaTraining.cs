namespace NinjAPI.Models
{
    public class NinjaTraining
    {
        public Guid Guid { get; set; }
        public Guid NinjaId { get; set; }
        public Ninja Ninja { get; set; }
        public Guid TrainingId { get; set; }
        public Training Training { get; set; }

    }
}
