using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class 華納威秀 : MovieTheater
    {
        public 華納威秀()
        {
            this.TicketList = new List<string>() { "學生票", "全票", "兒童票" };
        }

        public override Ticket CreatTicket(string type)
        {
            if (type.Equals(TicketList[0]))
                return new StudentTicket();
            else if (type.Equals(TicketList[1]))
                return new AdultTicket();
            else
                return new AdultTicket();
        }

        public override string ToString()
        {
            return string.Format("共計{0}元", tatleCost);
        }
    }
}