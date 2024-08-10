namespace MueblesAmerica.Domain.Ports.Out.User
{
    public interface IUserRepositoryPort
    {
        void AddUser(Models.User user);
        Models.User GetUserById(int id);
        List<Models.User> GetAllUsers();
        void UpdateUser(Models.User user);
        void DeleteUser(int id);
    }
}
