using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClassLibrary
{
    internal enum KeyName
    {
    }

    internal enum ValueName
    {
    }

    public class Index
    {
        private Dictionary<string, string> dictionary;

        private void BuildDictionary()
        {
            dictionary = new Dictionary<string, string>();
            dictionary.Add("test", "test");
        }
    }
}