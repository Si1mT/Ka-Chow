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
                    Console.WriteLine("Insert Note name");
                    string choiseDva = Console.ReadLine();
                    StreamReader sr = new StreamReader("C:\\Users\\opilane\\Desktop\\notes" + "\\" + choiseDva + ".txt");

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
                    Console.WriteLine("Executing finally block.");
                }
            }
            if (choise == "N")
            {
                Console.WriteLine("What should the filename be?");
                string choise3 = Console.ReadLine();
                string path = ("C:\\Users\\opilane\\Desktop\\notes" + "\\" + choise3 + ".txt");

                try
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    using (FileStream fs = File.Create(path))
                    {
                        Console.WriteLine("Enter text that you wish to type");
                        string UserText = Console.ReadLine();
                        Console.WriteLine("Save or Abort?[S/A]");
                        string choise4 = Console.ReadLine();
                        if (choise4 == "S")
                        {
                            Byte[] info = new UTF8Encoding(true).GetBytes(UserText);

                            fs.Write(info, 0, info.Length);
                        }
                        if (choise4 == "A")
                        {
                            goto Start;
                        }

                    }
                    using (StreamReader sr = File.OpenText(path))
                    {
                        Console.WriteLine("This is the file text now");
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                goto Start;
            }
            if (choise == "D")
            {
                Console.WriteLine("Enter Note you wish to delete");
                string choise6 = Console.ReadLine();
                string path2 = ("C:\\Users\\opilane\\Desktop\\notes" + "\\" + choise6 + ".txt");
                if (File.Exists(path2))
                {
                    File.Delete(path2);
                }
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
