using System;

namespace NutriAppServer.Domain.Entities
{
    public class Customer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime Birthdate { get; private set; }      
        public decimal Weight { get; private set; }
        public decimal Height { get; private set; }
        public string PhoneNumber { get; set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool FoodProblems { get; set; }
        public string DescriptionFoodProblems { get; private set; }
        public bool AnyDesease { get; private set; }
        public string DescriptionDesease { get; private set; }
    }
}