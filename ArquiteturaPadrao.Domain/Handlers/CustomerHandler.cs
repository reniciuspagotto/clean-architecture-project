using ArquiteturaPadrao.Domain.Command;
using ArquiteturaPadrao.Domain.Entities;
using ArquiteturaPadrao.Domain.Repositories;
using ArquiteturaPadrao.Shared.Commands;

namespace ArquiteturaPadrao.Domain.Handlers
{
    public class CustomerHandler :
        IHandler<CreateCustomerCommand>,
        IHandler<EditCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public object Handle(CreateCustomerCommand command)
        {
            var user = new User(command.Username, command.Password);
            var customer = new Customer(command.FirstName, command.LastName, command.Birthdate,
                command.PhoneNumber, command.Email, user);

            //TODO - IMPLEMENTAR TODO O FLUXO DA ENTIDADE ANTES DE SALVAR

            return _customerRepository.Save(customer);
        }

        public object Handle(EditCustomerCommand command)
        {
            //TODO - IMPLEMENTAR TODO O FLUXO DA ENTIDADE ANTES DE EDITAR

            return null;
        }
    }
}