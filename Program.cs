using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("mis teha tahate(create/edit/delete)");
            //string ans = Console.ReadLine();
            //if (ans == create)
            //{

            //}
            //Console.ReadLine();
            String line;
            Console.WriteLine("kas tahad näha märkmet?(y/n)");
            string ans = Console.ReadLine();
            if (ans =="y")
            {
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    StreamReader sr = new StreamReader("C:\\Users\\opilane\\Desktop\\notes\\geodwad.txt");

                    //Read the first line of text
                    line = sr.ReadLine();

                    //Continue to read until you reach end of file
                    while (line != null)
                    {
                        //write the lie to console window
                        Console.WriteLine(line);
                        //Read the next line
                        line = sr.ReadLine();
                    }

                    //close the file
                    sr.Close();
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
                Console.ReadKey();
            }
            else if (ans =="n")
            {
                Console.WriteLine("ok");
                Console.ReadLine();
            }
        }
    }
}
