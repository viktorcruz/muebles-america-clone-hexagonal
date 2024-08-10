using MueblesAmerica.Domain.Ports.In.User;

namespace MueblesAmerica.Application.UseCases.User
{
    public class CreateUserUseCase
    {
        private readonly CreateUserCommand _createUserUseCase;
        public CreateUserUseCase(CreateUserCommand createUserUseCase)
        {
            _createUserUseCase = createUserUseCase;
        }

        public void CreateUser(Domain.Models.User user)
        {
            _createUserUseCase.Execute(user);
        }
    }
}
