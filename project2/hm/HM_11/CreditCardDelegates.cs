using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_11
{
    internal class CreditCardDelegates
    {
        public static void main()
        {
            Predicate<string> IsValid = pin =>
            {
                if (pin.Length > 4) return false;
                foreach (char c in pin)
                {
                    if (!char.IsDigit(c)) return false;
                }
                return true;
            };
            Console.WriteLine(IsValid("1111"));
            Action<int> PrintAccount = amount =>
            {
                Console.WriteLine($"Amount of money on card: {amount}");
            };
            PrintAccount(12345);
            Func<int, int, int> Withdraw = (money, accountMoney) =>
            {
                if (accountMoney - money < 0) throw new Exception("Not enough money to withdraw");
                Console.WriteLine($"Withdrawal {money}; Money left on card {accountMoney}");
                return accountMoney - money;
            };
            Console.WriteLine(Withdraw(12345, 1000000));
        }
    }
}
