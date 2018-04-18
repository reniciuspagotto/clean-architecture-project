using ArquiteturaPadrao.Domain.Command.User;
using ArquiteturaPadrao.Shared.Commands;
using System;

namespace ArquiteturaPadrao.Domain.Handlers
{
    public class UserHandler : IHandler<GetUserCommand>
    {
        public object Handle(GetUserCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
