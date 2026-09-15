using QuickDish.Clients.External;

namespace QuickDish.Clients
{
    public interface IMealDbClient
    {
        Task<MealDbCategoryResponse?> GetCategoriesAsync(CancellationToken cancellationToken = default);
    }
}