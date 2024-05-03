using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovni_sustav_DZ1
{
    class Bank
    {
        private List<BankUser> users = new List<BankUser>();
        public Bank(List<BankUser> users)
        {
            this.users = users;
        }
        public void ExecuteTransaction(Transaction transaction)
        {
            transaction.Execute();
        }

        
    }
}
