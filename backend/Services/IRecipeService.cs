using QuickDish.Models;

namespace QuickDish.Services
{
    public interface IRecipeService
    {
        Task<List<CategoryDto>> GetCategoriesAsync(CancellationToken cancellationToken = default);
    }
}