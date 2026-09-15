using System.Text.Json.Serialization;

namespace QuickDish.Clients.External
{
    public class MealDbCategoryResponse
    {
        [JsonPropertyName("categories")]
        public List<MealDbCategory> Categories { get; set; } = new();
    }
}