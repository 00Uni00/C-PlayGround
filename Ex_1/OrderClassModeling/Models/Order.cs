using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderClassModeling.Models
{
    class Order
    {
        public int Id { get; private set; }
        public decimal Price { get; private set; }
        public decimal TaxRate { get; } = 0.23M;
        public decimal Balance 
        {
            get 
            {
                return Price * (1 + TaxRate); 
            } 
        }
    
        public Order(int id, decimal price) 
        {
            if (price <= 0) 
            {
                throw new Exception("Price must be greater then zero.");
            }
            Id = id;
            Price = price;  
        }
    }
}
