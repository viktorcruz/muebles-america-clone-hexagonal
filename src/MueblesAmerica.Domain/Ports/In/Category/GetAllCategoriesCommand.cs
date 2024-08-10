using MueblesAmerica.Domain.Ports.Out.Category;

namespace MueblesAmerica.Domain.Ports.In.Category
{
    public class GetAllCategoriesCommand
    {
        private readonly ICategoryRepositoryPort _categoryRepositoryPort;

        public GetAllCategoriesCommand(ICategoryRepositoryPort categoryRepositoryPort)
        {
            _categoryRepositoryPort = categoryRepositoryPort;
        }

        public Task<List<Domain.Models.Category>> Execute()
        {
            return _categoryRepositoryPort.GetAllCategories();
        }
    }
}
