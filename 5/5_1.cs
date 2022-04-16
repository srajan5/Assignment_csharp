using System;
namespace Arrays
{
    public class program
    {
        public static void Main()
        {
            int[] intarray = new int[3];
            String[] stringarray = new String[3];

            Console.WriteLine("Enter The three values for Integer Array");
            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < intarray.Length; i++)
            {
                Console.WriteLine("Enter the {0} value",i+1);
                intarray[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Enter The three values for String Array");
            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < stringarray.Length; i++)
            {
                Console.WriteLine("Enter the {0} value", i + 1);
                stringarray[i] =Console.ReadLine();

            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Copying elements of int array to another.....");
            int[] intarray2 = new int[3];
            intarray.CopyTo(intarray2, 0);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Int Array:");
            foreach (int i in intarray2)
            {
                Console.WriteLine("int array2[{0}]: {1}", i, i);
            }
            string[] stringarray2 = new string[3];
            stringarray.CopyTo(stringarray2, 0);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Sring Array:");
            foreach (string i in stringarray2)
            {
                Console.WriteLine("string array2[{0}]: {1}", i, i);
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Reversing the array.....");
            Array.Reverse(intarray);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Int Array:");
            for (int i = 0; i < intarray.Length; i++)
            {
                Console.WriteLine("int array[{0}]: {1}", i, intarray[i]);
            }
            Array.Reverse(stringarray);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("String Array:");
            for (int i = 0; i < stringarray.Length; i++)
            {
                Console.WriteLine("string array[{0}]: {1}", i, stringarray[i]);
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Sorting the array.....");
            Array.Sort(intarray);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Int Array:");
            for (int i = 0; i < intarray.Length; i++)
            {
                Console.WriteLine("int array[{0}]: {1}", i, intarray[i]);
            }
            Array.Sort(stringarray);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("String Array:");
            for (int i = 0; i < stringarray.Length; i++)
            {
                Console.WriteLine("string array[{0}]: {1}", i, stringarray[i]);
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Performing Clear in the array.....");
            Array.Clear(intarray);
            Console.WriteLine();
            Console.WriteLine("Int Array: ");
            foreach (int i in intarray)
            {
                Console.WriteLine("int array[{0}]: {1}", i, i);
            }
            Array.Clear(stringarray);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("String Array:");
            foreach (string i in stringarray)
            {
                Console.WriteLine("string array[{0}]: {1}", i, i);
            }


        }
    }
}

