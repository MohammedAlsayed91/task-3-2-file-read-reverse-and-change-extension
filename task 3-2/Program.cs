using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string location = @"C:\Users\User\OneDrive\Desktop\file\task3-2.txt";


            // FileInfo file = new FileInfo(location);
            // file.Create();
            // Console.WriteLine("successfully created");

            using (StreamWriter sw = File.AppendText(location))
            {
                var x = Console.ReadLine();
                sw.WriteLine(x);

                sw.Close();
                Console.WriteLine("done");
            }




            if (File.Exists(location))
            {
                string[] lines;
                using (StreamReader reader = new StreamReader(location))
                {
                    lines = File.ReadAllLines(location);
                }

                for (int i = 0; i < lines.Length; i++)
                {
                    char[] charArray = lines[i].ToCharArray();
                    Array.Reverse(charArray);
                    lines[i] = new string(charArray);
                }


                string newfile = Path.ChangeExtension(location, "inv");
                File.WriteAllLines(newfile, lines);

                Console.WriteLine("File copied and reversed successfully.");
            }
            else
            {
                Console.WriteLine("Original file does not exist.");
            }
        }
    }

}
    

