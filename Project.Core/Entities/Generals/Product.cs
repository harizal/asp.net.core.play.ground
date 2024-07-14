namespace Project.Core.Entities.Generals
{
    public class Product : BaseEntity<Guid>
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
