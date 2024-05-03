using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovni_sustav_DZ1
{
    class BankUser : Person, IBankAccount
    {
        private decimal balance;
        private DateTime joiningDate;
        public BankUser(decimal balance, DateTime joiningDate, string name, string surname, int id) 
        {
            this.balance = balance;
            this.joiningDate = joiningDate;
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void PutMoney(decimal amount)
        {
            balance += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            if(amount <= balance && balance > 0)
            {
                balance -= amount; 
            }
           
        }
    }
}
