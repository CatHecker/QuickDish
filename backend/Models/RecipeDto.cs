namespace QuickDish.Models
{
    public record RecipeDto
    {
        public string Id { get; init; } = default!;
        public string Name { get; init; } = default!;
        public string Instructions { get; init; } = default!;
        public string? ImageUrl { get; init; }
        public List<IngredientDto> Ingredients { get; init; } = new();
    }
}