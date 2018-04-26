using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string eventLine;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"d:\input.txt");
            while ((eventLine = file.ReadLine()) != null)
            {
                System.Console.WriteLine(eventLine);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} Event lines.", counter);
            System.Console.ReadLine();
        }
    }
}
