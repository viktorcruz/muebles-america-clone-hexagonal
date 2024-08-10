using MueblesAmerica.Domain.Ports.In.User;

namespace MueblesAmerica.Application.UseCases.User
{
    public class GetUserByIdUseCase
    {
        private readonly GetUserByIdCommand _getUserByIdUseCase;

        public GetUserByIdUseCase(GetUserByIdCommand getUserByIdUseCase)
        {
            _getUserByIdUseCase = getUserByIdUseCase;
        }

        public Domain.Models.User GetUserById(int id)
        {
            return _getUserByIdUseCase.GetUserById(id);
        }
    }
}
