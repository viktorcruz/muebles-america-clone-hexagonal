using Microsoft.Extensions.Configuration;
using MueblesAmerica.Infrastructure.Interface;
using Microsoft.Data.SqlClient;
using System.Data;


namespace MueblesAmerica.Infrastructure.Factories
{
    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public SqlConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection(string connectionName)
        {
            var connection = _configuration.GetConnectionString(connectionName);
            if (connection == null)
            {
                throw new ArgumentException("The connection string cannot be null or empty", nameof(connectionName));
            }
            return new SqlConnection(connection);
        }
    }
}
