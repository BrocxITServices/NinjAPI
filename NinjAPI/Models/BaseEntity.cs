using System.ComponentModel.DataAnnotations;

namespace NinjAPI.Models
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
