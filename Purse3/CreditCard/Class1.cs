using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreditCard
{
    public class CreditCard
    {
        public decimal amount = 0;
        private string msg = "Mennyi penzed van? Szeretlek ";

        public string GetSumCreditCard()
        {
            return msg + amount.ToString();
        }

        public CreditCard(decimal amount)
        {
            this.amount = amount;
        }
    }
}
