using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovni_sustav_DZ1
{
    class MoneyWithdrawl : Transaction
    {
        private BankUser user;
        public MoneyWithdrawl(BankUser user, decimal amount, DateTime date)
        {
            this.user = user;
            this.Amount = amount;
            this.Date = date;
        }

        
        public override void Execute()
        {
            user.WithdrawMoney(Amount);
        }

    }
}
