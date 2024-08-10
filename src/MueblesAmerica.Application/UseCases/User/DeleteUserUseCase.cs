using MueblesAmerica.Domain.Ports.In.User;

namespace MueblesAmerica.Application.UseCases.User
{
    public class DeleteUserUseCase
    {
        private readonly DeleteUserCommand _deleteUserUseCase;

        public DeleteUserUseCase(DeleteUserCommand deleteUserUseCase)
        {
            _deleteUserUseCase = deleteUserUseCase;
        }

        public void DeleteUser(int id)
        {
            _deleteUserUseCase.Execute(id);
        }
    }
}
