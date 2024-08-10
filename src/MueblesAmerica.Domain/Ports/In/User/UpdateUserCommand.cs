using MueblesAmerica.Domain.Ports.Out.User;

namespace MueblesAmerica.Domain.Ports.In.User
{
    public class UpdateUserCommand
    {
        private readonly IUserRepositoryPort _userRepositoryPort;

        public UpdateUserCommand(IUserRepositoryPort userRepositoryPort)
        {
            _userRepositoryPort = userRepositoryPort;
        }

        public void UpdateUser(Models.User user)
        {
            _userRepositoryPort.UpdateUser(user);
        }
    }
}
