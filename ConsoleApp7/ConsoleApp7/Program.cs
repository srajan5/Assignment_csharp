﻿using System;
using System.IO;

namespace UsingIONamespace
{
    class Program
    {
        static void Main()
        {
            string P0F = Path.GetTempFileName();
            var fi1 = new FileInfo(P0F);

            
            using (StreamWriter sw = fi1.CreateText())
            {
                sw.WriteLine("  Created a file and writing in it.");
               
            }

            
            using (StreamReader sr = fi1.OpenText())
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            string[] text = File.ReadAllLines(@"F:\Assignment_7_practice_file")
                ;
            foreach (string line in text)
            {
                Console.WriteLine(line);
            }


            string path = @"F:\Assignment_7_practice_file";

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully.");

                // Delete the directory.
                di.Delete();
                Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }


            string sourceDirectory = @"F:\Assignment_7_practice_file";
            string archiveDirectory = @"F:\Assignment_7_practice_file";

            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt");

                foreach (string currentFile in txtFiles)
                {
                    string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    Directory.Move(currentFile, Path.Combine(archiveDirectory, fileName));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
