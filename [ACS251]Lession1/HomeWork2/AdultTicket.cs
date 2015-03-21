using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class AdultTicket : Ticket
    {
        public AdultTicket()
        {
            this.Name = "全票";
            this.Cost = 100;
            this.SaleOff = 1;
        }
    }
}