using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestReflction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Assembly testAssembly = Assembly.LoadFile(@"C:\Users\bobho\Documents\visual studio 2012\Projects\[ACS251]Lession1\Test\bin\Debug\Test.dll");
            Type calcType = testAssembly.GetType("Test.TestClass");
            object calcInstance = Activator.CreateInstance(calcType);
            PropertyInfo numberPropertyInfo = calcType.GetProperty("Name");
            string value = (string)numberPropertyInfo.GetValue(calcInstance, null);
            Console.WriteLine(value);
        }
    }
}