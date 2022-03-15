using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ConsoleApp //<-------- NameSpace Section Declaration
{
    internal class Program //<-------Class Declaration
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "This is the first class of c#";



            int a, b, c;

            Console.WriteLine("Enter Two number:");
            a = int.Parse(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine()); //type Cast

            c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();

            //name,rolll, marks of 3 Subjects and Avg  print 

        }
    }
}
