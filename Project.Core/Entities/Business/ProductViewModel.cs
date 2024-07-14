namespace Project.Core.Entities.Business
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public required string CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
