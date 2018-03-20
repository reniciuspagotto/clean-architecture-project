using ArquiteturaPadrao.Domain.Entities;
using System.Collections.Generic;

namespace ArquiteturaPadrao.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Customer Save(Customer customer);
        Customer Edit(Customer customer);
        IEnumerable<Customer> Get();
    }
}