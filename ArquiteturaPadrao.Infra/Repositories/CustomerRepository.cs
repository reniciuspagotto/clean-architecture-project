using System.Collections.Generic;
using ArquiteturaPadrao.Domain.Entities;
using ArquiteturaPadrao.Domain.Repositories;
using ArquiteturaPadrao.Infra.Context;

namespace ArquiteturaPadrao.Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        protected DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public Customer Edit(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Customer> Get()
        {
            throw new System.NotImplementedException();
        }

        public Customer Save(Customer customer)
        {
            var dataReturn = _context.Add(customer);
            return customer;
        }
    }
}
