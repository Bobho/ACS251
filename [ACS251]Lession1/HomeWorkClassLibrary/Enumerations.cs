using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClassLibrary
{
    internal enum Ticket
    {
        學生票 = 0,
        全票 = 1,
        兒童票 = 2,
        ALL = 3,
    }

    public class Enumerations
    {
        private string s;
        private List<string> ticketList;

        public List<string> TicketList
        {
            get
            {
                GetList();
                return ticketList;
            }
        }

        private void GetList()
        {
            ticketList = new List<string>();
            for (int i = 0; i < (int)Ticket.ALL; i++)
            {
                s = Enum.GetName(typeof(Ticket), i);
                ticketList.Add(s);
            }
        }
    }
}