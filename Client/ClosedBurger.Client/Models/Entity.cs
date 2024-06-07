using System.ComponentModel.DataAnnotations;

namespace ClosedBurger.Client.Models
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
        public bool? IsActive { get; set; }
    }
}
