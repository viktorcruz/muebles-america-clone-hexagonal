using MueblesAmerica.Domain.Ports.Out.Category;

namespace MueblesAmerica.Domain.Ports.In.Category
{
    public class CreateCategoryCommand
    {
        private readonly ICategoryRepositoryPort _categoryRepositoryPort;

        public CreateCategoryCommand(ICategoryRepositoryPort categoryRepositoryPort)
        {
            _categoryRepositoryPort = categoryRepositoryPort;
        }

        public void Execute(Models.Category category)
        {
            _categoryRepositoryPort.AddCategory(category);
        }
    }
}
