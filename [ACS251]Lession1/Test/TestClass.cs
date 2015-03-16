using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestClass
    {
        public enum ClassName
        {
            Ticket = 0,
            ListTicket = 1,
        }

        private string name = "My name is Bob.";

        public string Name { get { return name; } }

        public TestClass()
        {
        }

        public void TestFunction()
        {
        }
    }
}