using MueblesAmerica.Domain.Ports.Out.Category;

namespace MueblesAmerica.Domain.Ports.In.Category
{
    public class GetCategoryByIdCommand
    {
        private readonly ICategoryRepositoryPort _categoryRepositoryPort;

        public GetCategoryByIdCommand(ICategoryRepositoryPort categoryRepositoryPort)
        {
            _categoryRepositoryPort = categoryRepositoryPort;
        }

        public Models.Category Execute(int id)
        {
            return _categoryRepositoryPort.GetCategoryById(id);
        }

    }
}
