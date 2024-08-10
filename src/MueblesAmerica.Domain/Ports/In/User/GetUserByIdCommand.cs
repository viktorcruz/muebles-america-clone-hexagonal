using MueblesAmerica.Domain.Ports.Out.User;

namespace MueblesAmerica.Domain.Ports.In.User
{
    public class GetUserByIdCommand
    {
        private readonly IUserRepositoryPort _userRepositoryPort;

        public GetUserByIdCommand(IUserRepositoryPort userRepositoryPort)
        {
            _userRepositoryPort = userRepositoryPort;
        }

        public Models.User GetUserById(int id)
        {
            return _userRepositoryPort.GetUserById(id);
        }
    }
}
