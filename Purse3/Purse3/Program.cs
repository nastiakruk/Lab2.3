﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Purse3
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessCard.BusinessCard qwe = new BusinessCard.BusinessCard("asd");
            Console.WriteLine(qwe.FindOutWhose());
        }
    }
}
