using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            double cur_bal = 50.38;
            double amount;
            Console.WriteLine("Please enter a amount to update account by $");
            amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Customer's balance before transaction = $");
            double cus_amt = double.Parse(Console.ReadLine());

            Console.WriteLine(cur_bal + "\n");
            Console.WriteLine("Requested update amount = $");
            double requested_amt = double.Parse(Console.ReadLine());

            Console.WriteLine(amount +"\n");
            double actAmount;
            actAmount = transaction(cur_bal, amount);
            cur_bal += actAmount;
            Console.WriteLine("acount update amount = $");
            double Amount = double.Parse(Console.ReadLine());

            Console.WriteLine(actAmount + "\n");

            Console.WriteLine("customer's balance after transaction = $");
            double after_transaction  = double.Parse(Console.ReadLine());

            Console.WriteLine(cur_bal + "\n");
            Console.WriteLine("\n Thank You and good-bye!\n");
            Console.ReadLine();
        }
        public static double transaction(double bal, double amount)
        {
            if (amount > 0)
            {
                return bal + amount;
            }
            if (bal < amount)
            {
                return bal;
            }
            return bal - amount;

        }  

    }
}
