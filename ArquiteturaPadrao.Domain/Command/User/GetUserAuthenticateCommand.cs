using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaPadrao.Domain.Command.User
{
    public class GetUserAuthenticateCommand
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
    }
}
