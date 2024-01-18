namespace NinjAPI.Models
{
    public class Training
    {
        public Guid TrainingId { get; set; }
        public TrainingTitle Title { get; set; }
        public string Trainer { get; set; }

        //Navigation property | Each training has access to one Ninja
        public Ninja? Ninja { get; set; }
    }
    public enum TrainingTitle
    {
        HandToHandCombat = 0,
        SwordFighting = 1,
        ShurikenThrowing = 3,
        Stealth = 4,
        Acrobatics = 5,
        Interrogation = 6,

    }
}
