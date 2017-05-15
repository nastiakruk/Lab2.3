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
            CreditCard.CreditCard asd = new CreditCard.CreditCard(123);
            asd.GetSumCreditCard();
            BusinessCard.BusinessCard qwe = new BusinessCard.BusinessCard("asd");
            Console.WriteLine(qwe.FindOutWhose());
            Lipstick.Lipstick abc = new Lipstick.Lipstick(true);
            Console.WriteLine(abc.CheckExistance());
        }
    }
}
