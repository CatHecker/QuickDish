using System.Text.Json.Serialization;

namespace QuickDish.Clients.External
{
    public class MealDbCategory
    {
        [JsonPropertyName("idCategory")]
        public string IdCategory { get; set; } = default!;

        [JsonPropertyName("strCategory")]
        public string StrCategory { get; set; } = default!;
    }
}