using Microsoft.AspNetCore.Mvc;
using MueblesAmerica.Application.UseCases.Category;

namespace MueblesAmerica.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly CreateCategoryUseCase _createCategoryUseCase;
        private readonly GetAllCategoriesUseCase _getAllCategoriesUseCase;
        private readonly GetCategoryByIdUseCase _getCategoryByIdUseCase;
        private readonly UpdateCategoryUseCase _updateCategoryUseCase;
        private readonly DeleteCategoryUseCase _deleteCategoryUseCase;

        public CategoryController(
            CreateCategoryUseCase createCategoryUseCase,
            GetAllCategoriesUseCase getAllCategoriesUseCase,
            GetCategoryByIdUseCase getCategoryByIdUseCase,
            UpdateCategoryUseCase updateCategoryUseCase,
            DeleteCategoryUseCase deleteCategoryUseCase
            )
        {
            _createCategoryUseCase = createCategoryUseCase;
            _getAllCategoriesUseCase = getAllCategoriesUseCase;
            _getCategoryByIdUseCase = getCategoryByIdUseCase;
            _updateCategoryUseCase = updateCategoryUseCase;
            _deleteCategoryUseCase = deleteCategoryUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] Domain.Models.Category category)
        {
            try
            {
                _createCategoryUseCase.CreateCategory(category);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{categoryId}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            try
            {
                var response = _getCategoryByIdUseCase.GetCategoryById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            try
            {
                var response = _getAllCategoriesUseCase.GetAllCategories();
                return Ok();
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(Domain.Models.Category category)
        {
            try
            {
                _updateCategoryUseCase.UpdateCategory(category);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{categoryId}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                _deleteCategoryUseCase.DeleteCategory(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

