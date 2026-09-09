using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleConstructors
{
    internal class Customer
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string Phone { get; set; }

        // Custom Constructor
        public Customer(string firstName, string lastName, string phone) 
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }
        public Customer(string firstName)
        {
            FirstName = firstName;
        }
    }
}
