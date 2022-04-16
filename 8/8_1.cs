using System;
using System.Reflection;

namespace Reflection
{
    public class ReflectionUsage
    {
        public static void ReflectionExample()
        {
            Assembly AS = Assembly.LoadFrom(@"F:\ConsoleApp1\ConsoleApp1\bin\Debug\net6.0\ConsoleApp1.dll");

            Type[] T = AS.GetTypes();
            foreach (Type t in T)
            {
                Console.WriteLine(t.FullName);
            }
        }

        public static void Main()
        {
            Console.WriteLine("Display the available types and their members.");
            ReflectionExample();
        }
    }
}