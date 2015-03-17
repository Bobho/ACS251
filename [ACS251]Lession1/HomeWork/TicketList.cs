using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HomeWork
{
    public class TicketList
    {
        private string ticketDll;
        private string appSettingName;
        private string typeName;
        private string propertyName;

        private List<string> ticketvalue;

        public List<string> TicketValue
        {
            get
            {
                ticketvalue = BuildList() as List<string>;
                return ticketvalue;
            }
        }

        public Dictionary<string, string[]> DictionaryClass
        {
            get
            {
                return BuildList() as Dictionary<string, string[]>;
            }
        }

        public TicketList(string appSettingName, string typeName, string propertyName)
        {
            this.appSettingName = appSettingName;
            this.typeName = typeName;
            this.propertyName = propertyName;
        }

        public object BuildList()
        {
            ticketDll = ConfigurationManager.AppSettings[appSettingName];
            Assembly testAssembly = Assembly.LoadFile(@ticketDll);
            Type calcType = testAssembly.GetType(typeName);
            object calcInstance = Activator.CreateInstance(calcType);
            PropertyInfo numberPropertyInfo = calcType.GetProperty(propertyName);
            return numberPropertyInfo.GetValue(calcInstance, null);
        }
    }
}