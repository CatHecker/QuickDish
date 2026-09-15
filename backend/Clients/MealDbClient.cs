using QuickDish.Clients.External;

namespace QuickDish.Clients
{
    public class MealDbClient(HttpClient httpClient, ILogger<MealDbClient> logger) : IMealDbClient
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly ILogger<MealDbClient> _logger = logger;

        public async Task<MealDbCategoryResponse?> GetCategoriesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<MealDbCategoryResponse>("categories.php", cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching categories from TheMealDB");
                return null;
            }
        }
    }
}