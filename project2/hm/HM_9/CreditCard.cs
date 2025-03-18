using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_9
{
    internal class CreditCard
    {
        private string _number;
        private string _name;
        private string _dateOfExpiration;
        private string _PIN;
        private int _limit;
        private int _currentSum;
        private int _creditMoney = 10000;
        public event Action<int> OnAddMoney;
        public event Action<int> OnSpendMoney;
        public event Action<int, int> UseCreditMoney;
        public event Action<int> OnLimit;
        public event Predicate<string> OnChangePin;

        public CreditCard(string number, string name, string doe, string pin, int limit)
        {
            _number = number;
            _name = name;
            _dateOfExpiration = doe;
            _PIN = pin;
            _limit = limit;
            _currentSum = 0;
        }

        public void addMoney(int amount)
        {
            _currentSum += amount;
            OnAddMoney(amount);
            if (_currentSum > _limit)
            {
                OnLimit(_currentSum);
            }
        }
        public void spendMoney(int amount)
        {
            _currentSum -= amount;
            OnSpendMoney(amount);
            if (_currentSum > 0)
            {
                UseCreditMoney(_currentSum, _creditMoney);
            }
        }
        public void ChangePIN(string PIN)
        {
            if (OnChangePin(_PIN))
            {
                _PIN = PIN;
            }
        }
    }
}
