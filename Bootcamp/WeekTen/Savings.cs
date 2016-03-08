using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekTen
{
    class Savings : Account
    {
        public override void Withdraw()
        {
            if (Balance > 300.00)
            {
                double currentAvailable = Balance - 300.00;
                Console.WriteLine("Current Available for withdrawal: ${0}", currentAvailable);
                base.Withdraw();
            }
            else
            {
                Console.WriteLine("Current balance must be greater than $300.00 to withdraw.");
            }
        }
    }
    /*
    static void Main(string[] args)
    {
        Savings longTerm = new Savings();
        longTerm.Deposit();
        longTerm.ViewBalance();
        longTerm.Withdraw();
    }
    */
}
