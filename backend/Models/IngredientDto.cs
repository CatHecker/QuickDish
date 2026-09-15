namespace QuickDish.Models
{
    public record IngredientDto
    {
        public string Name { get; init; } = default!;
        public string Measure { get; init; } = default!;
    }
}
