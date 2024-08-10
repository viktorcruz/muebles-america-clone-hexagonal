using MueblesAmerica.Domain.Ports.Out.User;

namespace MueblesAmerica.Infrastructure.Adapters.User
{
    public class UserRepositoryAdapter : IUserRepositoryPort
    {
        public UserRepositoryAdapter()
        {
            
        }

        public void AddUser(Domain.Models.User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Models.User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Domain.Models.User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Domain.Models.User user)
        {
            throw new NotImplementedException();
        }
    }
}
