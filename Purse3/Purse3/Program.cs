using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Purse3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Money.Money money = new Money.Money(500);
            money.GetMoney();
        }
    }
}
