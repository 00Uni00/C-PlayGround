using OrderClassModeling.Models;

namespace OrderClassModeling
{
    public class Program
    {
        static void Main(string[] args)
        {
            Order Table = new Order(1, 200);
            User Uni = new User("unimail@gmail.com", "Password123#$%");
            Uni.AddFunds(300);
            Console.WriteLine(Uni.Funds);
            Uni.PurchaseOrder(Table);
            Console.WriteLine(Uni.Funds);
        }
    }
}