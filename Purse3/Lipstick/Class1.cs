using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lipstick
{
    public class Lipstick
    {
        private bool Existance = false;
        public string CheckExistance()
        {
            return "Lipstick existance: " + Existance.ToString();
        }
        public Lipstick(bool Existance)
        {
            this.Existance = Existance;
        }

    }
}
