using MueblesAmerica.Domain.Ports.Out.User;

namespace MueblesAmerica.Domain.Ports.In.User
{
    public class CreateUserCommand
    {
        private readonly IUserRepositoryPort _userRepositoryPort;

        public CreateUserCommand(IUserRepositoryPort userRepositoryPort)
        {
            _userRepositoryPort = userRepositoryPort;
        }

        public void Execute(Models.User user)
        {
            _userRepositoryPort.AddUser(user);
        }
    }
}
