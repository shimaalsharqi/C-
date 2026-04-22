using System;
using System.IO;
using System.Diagnostics;


namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Create("test01.txt");
            //File.AppendAllText("test01.txt", "Hello from C#");

            //string[] dataType = { "int", "string", "float", "bool" };
            //File.AppendAllLines("test01.txt", dataType);




            #region Task01
            try
            {
                //File.Create("quiz01.txt");
                //File.Create("quiz02.txt");
                //File.Create("quiz03.txt");
                //File.AppendAllText("quiz01.txt", "Hello from quiz one");
                //File.AppendAllText("quiz02.txt", "Hello from quiz two");
                //File.AppendAllText("quiz03.txt", "Hello from quiz three");
                Console.WriteLine("Enter which quiz you want one,two or three");
                int user = Convert.ToInt32(Console.ReadLine());

                if (user == 1)
                {
                    Process.Start("NotePad.exe", "quiz01.txt");

                }
                else if (user == 2)
                {
                    Process.Start("NotePad.exe", "quiz02.txt");
                }
                else if (user == 3)
                {
                    Process.Start("NotePad.exe", "quiz03.txt");
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                    return;
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }

            #endregion
        }
    }
}

