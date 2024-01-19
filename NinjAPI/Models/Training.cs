using Microsoft.Identity.Client;

namespace NinjAPI.Models
{
    public class Training //: BaseEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Trainer { get; set; }
        public IList<NinjaTraining> NinjaTraining { get; set; }
    }
}
