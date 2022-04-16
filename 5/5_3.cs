using System;
using System.Collections.Generic;
namespace usingGenericList
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            List<Employee> el = new List<Employee>()
            {
                new Employee(){Id= 1, Name ="Aman"},
                new Employee(){Id= 2, Name ="Adarsh"},
                new Employee() {Id= 3, Name ="Arjit"}
            };

            emp.Add(new Employee() { Id = 1, Name = "Abik" });

            foreach (Employee emp in el)
            {
                emp.Display();
            }

            Console.WriteLine("Total number of Empoyees in the List are {0}", el.Count);
        }
    }
}
