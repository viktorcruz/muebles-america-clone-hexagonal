using Dapper;
using MueblesAmerica.Domain.Ports.Out.Category;
using MueblesAmerica.Infrastructure.Interface;

namespace MueblesAmerica.Infrastructure.Adapters.Category
{
    public class CategoryRepositoryAdapter : ICategoryRepositoryPort
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;
        private readonly string ConnectionString = "Muebles_America_Clone";

        public CategoryRepositoryAdapter(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        public async void AddCategory(Domain.Models.Category category)
        {
            using (var connection = _sqlConnectionFactory.GetConnection(ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var query = "Usp_Category_Add";
                        var parameters = new DynamicParameters();
                        parameters.Add("@Name", category.Name);
                        parameters.Add("@Description", category.Description);

                        var results = await connection.ExecuteAsync(
                            query,
                            parameters,
                            transaction,
                            commandType: System.Data.CommandType.StoredProcedure
                            );

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Domain.Models.Category>> GetAllCategories()
        {
            using (var connection = _sqlConnectionFactory.GetConnection(ConnectionString))
            {
                connection.Open();
                try
                {
                    var query = "Usp_Category_Add";
                    var results = await connection.QueryAsync<Domain.Models.Category>(query, commandType: System.Data.CommandType.StoredProcedure);

                    if (results.Any())
                    {
                        return results.ToList();
                    }
                }
                catch (Exception ex)
                {
                }
                return new List<Domain.Models.Category>();
            }
        }

        public Domain.Models.Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Domain.Models.Category category)
        {
            throw new NotImplementedException();
        }
    }
}
