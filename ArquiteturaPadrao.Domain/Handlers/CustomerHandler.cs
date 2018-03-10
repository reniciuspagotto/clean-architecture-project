using NutriAppServer.Domain.Command;
using NutriAppServer.Shared.Commands;

namespace NutriAppServer.Domain.Handlers
{
    public class CustomerHandler : IHandler<CreateCustomerCommand>
    {
        public object Handle(CreateCustomerCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}