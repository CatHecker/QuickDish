namespace QuickDish.Models
{
    public record CategoryDto
    {
        public string Id { get; init; } = default!;
        public string Name { get; init; } = default!;
    }
}