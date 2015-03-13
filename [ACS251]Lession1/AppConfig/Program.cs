using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppConfig
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string appString = System.Configuration.ConfigurationManager.AppSettings["name2"];

            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType(appString);
            object customerInstance = Activator.CreateInstance(customerType);
            MethodInfo getFullNameMethod = customerType.GetMethod("ddd");

            Console.WriteLine(customerType.GetProperty("aaa").GetValue(customerInstance, null));
            if (getFullNameMethod != null)
            {
                string fullname = getFullNameMethod.Name;
                Console.WriteLine(fullname);
            }

            /*
             Console.WriteLine(appString);
             Type T = Type.GetType(appString);

             if (T != null)
             {
                 PropertyInfo[] props = T.GetProperties();

                 Console.WriteLine(props[0].Name);
             }
             */
        }
    }
}