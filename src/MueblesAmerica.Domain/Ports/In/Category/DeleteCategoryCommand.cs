using MueblesAmerica.Domain.Ports.Out.Category;

namespace MueblesAmerica.Domain.Ports.In.Category
{
    public class DeleteCategoryCommand
    {
        private readonly ICategoryRepositoryPort _categoryRepositoryPort;

        public DeleteCategoryCommand(ICategoryRepositoryPort categoryRepositoryPort)
        {
            _categoryRepositoryPort = categoryRepositoryPort;
        }

        public void Execute(int id)
        {
            _categoryRepositoryPort.DeleteCategory(id);
        }
    }
}
