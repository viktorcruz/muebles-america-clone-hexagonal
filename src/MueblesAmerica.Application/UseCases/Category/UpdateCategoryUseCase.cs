using MueblesAmerica.Domain.Ports.In.Category;

namespace MueblesAmerica.Application.UseCases.Category
{
    public class UpdateCategoryUseCase
    {
        private readonly UpdateCategoryCommand _updateCategoryUseCase;

        public UpdateCategoryUseCase(UpdateCategoryCommand updateCategoryUseCase)
        {
            _updateCategoryUseCase = updateCategoryUseCase;
        }

        public void UpdateCategory(Domain.Models.Category category)
        {
            _updateCategoryUseCase.Execute(category);
        }
    }
}
