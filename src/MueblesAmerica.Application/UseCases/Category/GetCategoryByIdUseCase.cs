using MueblesAmerica.Domain.Ports.In.Category;

namespace MueblesAmerica.Application.UseCases.Category
{
    public class GetCategoryByIdUseCase
    {
        private readonly GetCategoryByIdCommand _getCategoryByIdUseCase;

        public GetCategoryByIdUseCase(GetCategoryByIdCommand getCategoryByIdUseCase)
        {
            _getCategoryByIdUseCase = getCategoryByIdUseCase;
        }

        public Domain.Models.Category GetCategoryById(int id)
        {
            return _getCategoryByIdUseCase.Execute(id);
        }
    }
}
