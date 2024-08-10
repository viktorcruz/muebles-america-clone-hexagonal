using MueblesAmerica.Domain.Ports.Out.Category;

namespace MueblesAmerica.Domain.Ports.Out.Category
{
    public interface ICategoryRepositoryPort
    {
        void AddCategory(Models.Category category);
        Models.Category GetCategoryById(int id);
        Task<List<Domain.Models.Category>> GetAllCategories();
        void UpdateCategory(Models.Category category);
        void DeleteCategory(int id);
    }
}
