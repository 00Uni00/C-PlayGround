using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderClassModeling.Models;

namespace OrderClassModeling.Models
{
    public interface IEmailSender 
    {
        void SendEmail(string reciver, string topic, string text);   
    }
    public interface IDatabase 
    {
        bool IsConnected { get; }
        void Connect();
        User GetUser();
        Order GetOrder();
        void SaveChanges();
    }
    public class Database : IDatabase
    {
        public bool IsConnected => throw new NotImplementedException();

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public Order GetOrder()
        {
            throw new NotImplementedException();
        }

        public User GetUser()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

    public class EmailSender : IEmailSender
    {
        public void SendEmail(string reciver, string topic, string text)
        {
            throw new NotImplementedException();
        }
    }

    public class SuceedPurchase 
    {
        private readonly Database _database;
        private readonly EmailSender _emailSender;
        public SuceedPurchase(Database database, EmailSender emailSender)
        {
            _database = database;
            _emailSender = emailSender;
        }
        public void ProcessOrder(string email, int orderId) 
        {
            User user = _database.GetUser();
            Order order = _database.GetOrder();
            user.PurchaseOrder(order);
            _database.SaveChanges();
            _emailSender.SendEmail(email,$"Order {orderId}" ,"Order complete.We will send you packet soon.");
        }
    }

}
