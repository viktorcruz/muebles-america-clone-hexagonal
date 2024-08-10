using MueblesAmerica.Domain.Ports.In.User;

namespace MueblesAmerica.Application.UseCases.User
{
    public class UpdateUserUseCase
    {
        private readonly UpdateUserCommand _updateUserUseCase;

        public UpdateUserUseCase(UpdateUserCommand updateUserUseCase)
        {
            _updateUserUseCase = updateUserUseCase;
        }

        public void UpdateUser(Domain.Models.User user)
        {
            _updateUserUseCase.UpdateUser(user);
        }
    }
}
