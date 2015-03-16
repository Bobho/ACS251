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
                BuildList();
                return ticketvalue;
            }
        }

        public TicketList(string appSettingName, string typeName, string propertyName)
        {
            this.appSettingName = appSettingName;
            this.typeName = typeName;
            this.propertyName = propertyName;
        }

        public void BuildList()
        {
            ticketDll = ConfigurationManager.AppSettings[appSettingName];
            Assembly testAssembly = Assembly.LoadFile(@ticketDll);
            Type calcType = testAssembly.GetType(typeName);
            object calcInstance = Activator.CreateInstance(calcType);
            PropertyInfo numberPropertyInfo = calcType.GetProperty(propertyName);
            ticketvalue = (List<string>)numberPropertyInfo.GetValue(calcInstance, null);
        }
    }
}