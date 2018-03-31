using ArquiteturaPadrao.Shared.Entity;
using System;

namespace ArquiteturaPadrao.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string firstName, string lastName, DateTime birthdate, string phoneNumber, string email, User user)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            PhoneNumber = phoneNumber;
            Email = email;
            User = user;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime Birthdate { get; private set; }      
        public string PhoneNumber { get; set; }
        public string Email { get; private set; }

        public Guid UserId { get; private set; }
        public User User { get; set; }
    }
}