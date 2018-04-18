using System;

namespace ArquiteturaPadrao.Domain.Command.User
{
    public class AuthenticateUserCommand
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
