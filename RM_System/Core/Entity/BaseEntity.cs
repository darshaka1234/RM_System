using System.ComponentModel.DataAnnotations;

namespace RM_System.Core.Entity
{
    public abstract class BaseEntity
    {
        [Key]
        public long ID { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;

    }
}
