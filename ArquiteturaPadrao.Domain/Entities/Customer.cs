using ArquiteturaPadrao.Shared.Entity;
using System;

namespace ArquiteturaPadrao.Domain.Entities
{
    public class Customer : Entity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime Birthdate { get; private set; }      
        public string PhoneNumber { get; set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}