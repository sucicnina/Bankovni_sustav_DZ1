using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovni_sustav_DZ1
{
    interface IBankAccount
    {
        void WithdrawMoney(decimal amount);
        void PutMoney(decimal amount);
        decimal GetBalance();
    }
}
