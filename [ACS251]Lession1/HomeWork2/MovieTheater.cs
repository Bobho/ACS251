using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal abstract class MovieTheater
    {
        public List<string> TicketList;
        public double tatleCost;

        public Ticket OrderTicket(string type)
        {
            Ticket ticket = CreatTicket(type);
            ticket.GetDiscount();

            return ticket;
        }

        public abstract Ticket CreatTicket(string type);
    }
}