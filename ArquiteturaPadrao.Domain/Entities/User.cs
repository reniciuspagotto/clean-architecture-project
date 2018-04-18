using ArquiteturaPadrao.Shared.Entity;
using ArquiteturaPadrao.Shared.Helper;

namespace ArquiteturaPadrao.Domain.Entities
{
    public class User : Entity
    {
        protected User() { }

        public User(string username, string password)
        {
            Username = username;
            Password = HashHelper.EncryptPassword(password);
            Active = true;
        }

        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }
    }
}
