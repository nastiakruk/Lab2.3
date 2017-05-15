using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Purse3
{
    class Program
    {
        static void Main(string[] args)
        {
            Lipstick.Lipstick abc = new Lipstick.Lipstick(true);
            Console.WriteLine(abc.CheckExistance());
        }
    }
}
