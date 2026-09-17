using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Arco : Arma
    {
        public override double CalcularAtaqueCritico()
        {
            return DanoBase * 3;
        }
    }
}
