using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class ChildDiscount : Ticket
    {
        public List<string> discountList = new List<string>() { "10歲以下", "屁海" };

        public override double DiscountSaleOff(string type)
        {
            if (type != null)
            {
                if (type.Equals(discountList[0]))
                    return this.SaleOff = .3;
                else if (type.Equals(discountList[1]))
                    return this.SaleOff = .7;
                else
                    return this.SaleOff = 1;
            }
            else
            {
                return this.SaleOff = 1;
            }
        }
    }
}