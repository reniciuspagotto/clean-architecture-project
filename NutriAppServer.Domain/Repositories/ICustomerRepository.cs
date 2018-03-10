using NutriAppServer.Domain.Entities;
using System.Collections.Generic;

namespace NutriAppServer.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Customer Save(Customer customer);
        Customer Edit(Customer customer);
        IEnumerable<Customer> Get();
    }
}