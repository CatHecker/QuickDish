using Microsoft.AspNetCore.Mvc;
using QuickDish.Models;
using QuickDish.Services;

namespace QuickDish.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController(IRecipeService recipeService) : ControllerBase
    {
        private readonly IRecipeService _recipeService = recipeService;

        // GET /api/recipes/categories
        [HttpGet("categories")]
        public async Task<ActionResult<List<CategoryDto>>> GetCategories(CancellationToken cancellationToken)
        {
            var categories = await _recipeService.GetCategoriesAsync(cancellationToken);
            return Ok(categories);
        }

        // GET /api/recipes/random?count=5
        /*[HttpGet("random")]
        public async Task<ActionResult<List<RecipeDto>>> GetRandomRecipes(
            [FromQuery] int count = 5, 
            CancellationToken cancellationToken = default)
        {
            // Пока заглушка, потом реализуем
            return Ok(new List<RecipeDto>());
        }*/
    }
}