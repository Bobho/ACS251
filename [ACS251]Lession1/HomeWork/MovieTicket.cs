using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork
{
    public abstract class MovieTicket
    {
        public MovieTicket(double price)
        {
            this.price = price;
        }

        public Discount discount;

        private double price;

        public double Price
        {
            get { return Discount(); }
        }

        public double Discount()
        {
            double value;

            if (discount != null)
                value = discount.Calculate(price);
            else
                value = 0;
            return value;
        }
    }
}