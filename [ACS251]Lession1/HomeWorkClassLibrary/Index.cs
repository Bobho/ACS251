using HomeWorkClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClassLibrary
{
    internal enum AppConfigKeyName
    {
        TicketDll,
    }

    internal enum KeyName
    {
        TicketList,
    }

    internal enum ValueName
    {
        HomeWorkClassLibrary,
        Enumerations,
    }

    public class Index
    {
        private Dictionary<string, string[]> dictionaryClass;

        public Dictionary<string, string[]> DictionaryClass
        {
            get
            {
                BuildDictionaryClass();
                return dictionaryClass;
            }
        }

        private void BuildDictionaryClass()
        {
            dictionaryClass = new Dictionary<string, string[]>();
            string[] test = { Enum.GetName(typeof(AppConfigKeyName), 0), Enum.GetName(typeof(ValueName), 0) + "." + Enum.GetName(typeof(ValueName), 1), Enum.GetName(typeof(KeyName), 0) };
            dictionaryClass.Add(Enum.GetName(typeof(KeyName), 0), test);
        }
    }
}