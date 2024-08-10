using MueblesAmerica.Domain.Ports.Out.User;

namespace MueblesAmerica.Domain.Ports.In.User
{
    public class DeleteUserCommand
    {
        private readonly IUserRepositoryPort _userRepositoryPort;

        public DeleteUserCommand(IUserRepositoryPort userRepositoryPort)
        {
            _userRepositoryPort = userRepositoryPort;
        }

        public void Execute(int id)
        {
            _userRepositoryPort.DeleteUser(id);
        }
    }
}
