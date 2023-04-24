using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderClassModeling.Models
{
    public class User
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Funds { get; private set; } = 0;

        public User(string email, string password)
        {
            SetEmail(email);
            SetPassowrd(password);
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email is incorrect.");
            }
            Email = email;
        }
        public void SetPassowrd(string password)
        {
            if(string.IsNullOrWhiteSpace(password)) 
            {
                throw new Exception("Password is incorrect.");
            }
            Password = password;
        }

        public void SetFirstName(string firstName) 
        {
            if(string.IsNullOrWhiteSpace(firstName)) 
            {
                throw new Exception("First Name is incorrect.");
            }
            FirstName = firstName;
        }

        public void SetLastName(string lastName) 
        {
            if(string.IsNullOrWhiteSpace(lastName)) 
            {
                throw new Exception("Last Name is incorrect.");
            }
            LastName = lastName;    
        }

        public void SetAge(int age) 
        {
            if(age < 18) 
            {
                throw new Exception("You must be an adult");
            }
            Age = age;
        }
        public void AddFunds(decimal funds)
        {
            if (funds <= 0)
            {
                throw new Exception("You can not add it to your balnace");
            }
            Funds += funds;
        }
        public void PurchaseOrder(Order order) 
        {
            decimal orderPrice = order.Balance;
            if (Funds - orderPrice < 0) 
            {
                throw new Exception("You do not have enough money.");
            }
            Funds -= orderPrice;
        }
    }
}
