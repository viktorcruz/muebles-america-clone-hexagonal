using MueblesAmerica.Domain.Ports.In.Category;

namespace MueblesAmerica.Application.UseCases.Category
{
    public class DeleteCategoryUseCase
    {
        private readonly DeleteCategoryCommand _deleteCategoryUseCase;

        public DeleteCategoryUseCase(DeleteCategoryCommand deleteCategoryUseCase)
        {
            _deleteCategoryUseCase = deleteCategoryUseCase;
        }

        public void DeleteCategory(int id)
        {
            _deleteCategoryUseCase.Execute(id);
        }
    }
}
