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
            var customer = new Customer();// DEVE ADICIONAR INICIALIZAÇÃODO OBJETO NO CONSTRUTOR

            //TODO - IMPLEMENTAR TODO O FLUXO DA ENTIDADE ANTES DE SALVAR

            return _customerRepository.Save(customer);
        }

        public object Handle(EditCustomerCommand command)
        {
            var customer = new Customer(); // DEVE ADICIONAR INICIALIZAÇÃODO OBJETO NO CONSTRUTOR

            //TODO - IMPLEMENTAR TODO O FLUXO DA ENTIDADE ANTES DE EDITAR

            return _customerRepository.Save(customer);
        }
    }
}