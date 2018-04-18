using ArquiteturaPadrao.Domain.Command.User;

namespace ArquiteturaPadrao.Domain.Repositories
{
    public interface IUserRepository
    {
        GetUserAuthenticateCommand UserLogin(string username, string password);
    }
}