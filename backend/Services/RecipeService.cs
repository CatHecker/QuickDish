using QuickDish.Clients;
using QuickDish.Models;

namespace QuickDish.Services
{
    public class RecipeService(IMealDbClient mealDbClient): IRecipeService
    {
        private readonly IMealDbClient _mealDbClient = mealDbClient;

        public async Task<List<CategoryDto>> GetCategoriesAsync(CancellationToken cancellationToken = default)
        {
            var response = await _mealDbClient.GetCategoriesAsync(cancellationToken);
            
            if (response?.Categories == null || !response.Categories.Any())
            {
                return new List<CategoryDto>();
            }

            return response.Categories.Select(category => new CategoryDto
            {
                Id = category.IdCategory,
                Name = category.StrCategory
            }).ToList();
        }
    }
}