using MueblesAmerica.Domain.Ports.In.Category;

namespace MueblesAmerica.Application.UseCases.Category
{
    public class CreateCategoryUseCase
    {
        private readonly CreateCategoryCommand _createCategoryUseCase;

        public CreateCategoryUseCase(CreateCategoryCommand createCategoryUseCase)
        {
            _createCategoryUseCase = createCategoryUseCase;
        }

        public void CreateCategory(Domain.Models.Category category)
        {
            _createCategoryUseCase.Execute(category);
        }
    }
}
