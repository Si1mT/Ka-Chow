using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

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
            Start:
            Console.WriteLine("Do you want to Read, Delete or Create New?[R/D/N]");
            Console.WriteLine("To quit type 'Q'");
            string choise = Console.ReadLine(); 
            if (choise == "R")
            {
                string line;
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    Console.WriteLine("Insert Note name");
                    string choiseDva = Console.ReadLine();
                    StreamReader sr = new StreamReader("C:\\Users\\opilane\\Desktop\\notes" + "\\" + choiseDva + ".txt");

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
            }
            if (choise == "N")
            {

            }
            if (choise == "D")
            {

            }
            if (choise == "Q")
            {
               Environment.Exit(1);
            }
            else
            {

                Console.WriteLine("Not a correct choise");
                Console.WriteLine("Do you wish to clear console and try again?");
                Console.WriteLine("Options: cl[CLears], ncl[doesnt Clear], q[Quits]");
                string choiseOdin = Console.ReadLine();
                if (choiseOdin == "cl")
                {
                    Console.WriteLine("Will display choises again");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Start;
                }
                if (choiseOdin == "ncl")
                {
                    Console.WriteLine("Will display choises again");
                    Thread.Sleep(1000);
                    goto Start;
                }
                if (choiseOdin == "q")
                {
                    Environment.Exit(1);
                }
                
            }
        }
    }
}
