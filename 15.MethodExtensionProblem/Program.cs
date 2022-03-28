using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.MethodExtensionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyWord = "C# is A Good Programing Language";
            int WordCount= MyWord.GetWordCount();

            Console.WriteLine("input String:"+ MyWord);
            Console.WriteLine("WordCount:" + WordCount);
            Console.ReadKey();




        }
    }
}
