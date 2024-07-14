using System.ComponentModel.DataAnnotations;

namespace Project.Core.Entities.Generals
{
    public class BaseEntity<T>
    {
        [Key]
        public required T Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public required string CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
