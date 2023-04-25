using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L6_Static
{
    internal class BankAccount
    {
        double _balance;

        public BankAccount(double balance)
        {
            _balance = balance;
        }

        // Create a static method that lets me combine balances
        public static BankAccount CombineAccounts(BankAccount b1, BankAccount b2)
        {
            return new BankAccount(b1._balance + b2._balance);
        }

        public override string ToString()
        {
            return $"This accounts balance is {_balance}";
        }

    } // class

} // namespace
