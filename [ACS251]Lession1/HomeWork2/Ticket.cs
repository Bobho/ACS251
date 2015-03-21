using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork2
{
    public abstract class Ticket
    {
        public string Name { get; set; }

        public double Cost { get; set; }

        public double SaleOff { get; set; }

        public int amount { get; set; }

        public double GetDiscount()
        {
            return this.Cost * this.SaleOff;
        }

        public double TatleCost()
        {
            return this.amount * this.GetDiscount();
        }

        public virtual double DiscountSaleOff(string type)
        {
            return SaleOff;
        }

        public override string ToString()
        {
            string description = string.Empty;
            description += string.Format("一張{0},", this.Name);
            description += string.Format("原價{0},", this.Cost);
            description += string.Format("特價{0},", this.GetDiscount());
            description += string.Format("共{0}張,", this.amount);
            description += string.Format("共計{0}\n", this.TatleCost());
            return description;
        }
    }
}