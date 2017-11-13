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
                    StreamReader sr = new StreamReader("C:\\Users\\SIIM\\Desktop\\notes\\oke.txt");

                    line = sr.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = sr.ReadLine();
                    }

                    sr.Close();
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("oops");
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
