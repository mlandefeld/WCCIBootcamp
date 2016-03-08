using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekTen
{
    abstract class Account  //abstact means there will be no account objects
    {
        private double balance;

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public virtual void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            double amount = double.Parse(Console.ReadLine());
            Balance = Balance - amount;
        }

        public void Deposit()
        {
            Console.WriteLine("how much would you like to deposit?");
            double amount = double.Parse(Console.ReadLine());
            Balance = Balance + amount;
        }

        public void ViewBalance()
        {
            Console.WriteLine(Balance);
        }
    }
}
