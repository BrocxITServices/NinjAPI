namespace NinjAPI.Models
{
    public class Training : BaseEntity
    {
        public string Title { get; set; }
        public Ninja Trainer { get; set; }
        public List<Ninja> Participants { get; set; }
    }
}
