using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class StudentTicket : Ticket
    {
        public StudentTicket()
        {
            this.Name = "學生票";
            this.Cost = 100;
            this.SaleOff = .8;
        }
    }
}