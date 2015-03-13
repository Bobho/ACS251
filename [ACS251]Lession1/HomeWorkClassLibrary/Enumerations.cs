using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClassLibrary
{
    internal enum ClassName
    {
        HomeWorkClassLibrary = 0,
        Enumerations = 1,
    }

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
        private List<string> ListS;

        public List<string> listTicket
        {
            get
            {
                GetList();
                return ListS;
            }
        }

        private void GetList()
        {
            ListS = new List<string>();
            for (int i = 0; i < (int)Ticket.ALL; i++)
            {
                s = Enum.GetName(typeof(Ticket), i);
                ListS.Add(s);
            }
        }
    }
}