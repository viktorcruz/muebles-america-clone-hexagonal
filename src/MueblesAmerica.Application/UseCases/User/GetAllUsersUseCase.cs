using MueblesAmerica.Domain.Ports.In.User;

namespace MueblesAmerica.Application.UseCases.User
{

    public class GetAllUsersUseCase
    {
        private readonly GetAllUsersCommand _getAllUsersUseCase;

        public GetAllUsersUseCase(GetAllUsersCommand getAllUsersUseCase)
        {
            _getAllUsersUseCase = getAllUsersUseCase;
        }

        public List<Domain.Models.User> GetAllUsers()
        {
            return _getAllUsersUseCase.GetAllUsers();
        }
    }
}
