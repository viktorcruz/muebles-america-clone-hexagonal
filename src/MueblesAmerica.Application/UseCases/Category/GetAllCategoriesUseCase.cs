using MueblesAmerica.Domain.Ports.In.Category;

namespace MueblesAmerica.Application.UseCases.Category
{
    public class GetAllCategoriesUseCase
    {
        private readonly GetAllCategoriesCommand _getAllCategoriesUseCase;

        public GetAllCategoriesUseCase(GetAllCategoriesCommand getAllCategoriesUseCase)
        {
            _getAllCategoriesUseCase = getAllCategoriesUseCase;
        }

        public Task<List<Domain.Models.Category>> GetAllCategories()
        {
            return _getAllCategoriesUseCase.Execute();
        }
    }
}
