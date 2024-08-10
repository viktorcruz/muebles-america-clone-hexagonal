using MueblesAmerica.Domain.Ports.Out.Category;

namespace MueblesAmerica.Domain.Ports.In.Category
{
    public class UpdateCategoryCommand
    {
        private readonly ICategoryRepositoryPort _categoryRepositoryPort;

        public UpdateCategoryCommand(ICategoryRepositoryPort categoryRepositoryPort)
        {
            _categoryRepositoryPort = categoryRepositoryPort;
        }

        public void Execute(Models.Category category)
        {
            _categoryRepositoryPort.UpdateCategory(category);
        }
    }
}
