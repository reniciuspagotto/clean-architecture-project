using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaPadrao.Domain.Command.User
{
    public class GetUserCommand
    {
        public string Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }
    }
}