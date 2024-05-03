using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovni_sustav_DZ1
{
    abstract class Transaction
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public abstract void Execute();
        
    }
}
