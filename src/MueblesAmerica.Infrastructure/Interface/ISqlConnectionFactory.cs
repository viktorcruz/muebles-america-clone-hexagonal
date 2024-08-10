using System.Data;

namespace MueblesAmerica.Infrastructure.Interface
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetConnection(string connectionName);
    }
}
