using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    class Paypal : IPaypal
    {
       public double Payment(double amount)
        {
            return amount++;

        }
       public double Investing(double amount, int month)
        {
            return month = 1;

        }
    }
}
