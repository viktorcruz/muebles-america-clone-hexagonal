using MueblesAmerica.Domain.Ports.Out.User;

namespace MueblesAmerica.Domain.Ports.In.User
{
    public class GetAllUsersCommand
    {
        private readonly IUserRepositoryPort _userRepositoryPort;

        public GetAllUsersCommand(IUserRepositoryPort userRepositoryPort)
        {
            _userRepositoryPort = userRepositoryPort;
        }

        public List<Models.User> GetAllUsers()
        {
            return _userRepositoryPort.GetAllUsers();
        }
    }
}
