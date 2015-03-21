using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class StudentDiscount : Ticket
    {
        public List<string> studentDiscountList = new List<string>() { "大學生", "小學生" };

        public override double DiscountSaleOff(string student)
        {
            if (student != null)
            {
                if (student.Equals(studentDiscountList[0]))
                    return this.SaleOff = .8;
                else if (student.Equals(studentDiscountList[1]))
                    return this.SaleOff = .7;
                else
                    return this.SaleOff = 1;
            }
            else
                return this.SaleOff = 1;
        }
    }
}