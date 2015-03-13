using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfig
{
    public class MyClass1
    {
        private string name;

        public string aaa { get { return "ccc"; } }

        public MyClass1()
        {
            this.name = aaa;
        }

        public string ddd(string eee)
        {
            return eee;
        }
    }
}