using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    public class Money
    {
        private decimal amount = 0;
        private string msg = "Sie haben Geld in Ihrer Natasha: ";
        public string GetMoney()
        {
            return msg + amount.ToString();
        }
        public Money(decimal amount)
        {
            this.amount = amount;
        }

    }

}
