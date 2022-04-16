using System;
using System.IO;

namespace UsingIONamespace
{
    class Program
    {
        static void Main()
        {
            string P0F = Path.GetTempFileName();
            var fi1 = new FileInfo(P0F);

            
            using (StreamWriter Swriter = fi1.CreateText())
            {
                Swriter.WriteLine("  Created a file and writing in it.");
               
            }

            
            using (StreamReader Sreader = fi1.OpenText())
            {
                var s = "";
                while ((s = Sreader.ReadLine()) != null)
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
                
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                
                DirectoryInfo Dinfo = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully.");


                Dinfo.Delete();
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
