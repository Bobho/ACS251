using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork
{
    public class StudentDiscount : Discount
    {
        public double Calculate(double price)
        {
            return price * 0.8;
        }
    }
}