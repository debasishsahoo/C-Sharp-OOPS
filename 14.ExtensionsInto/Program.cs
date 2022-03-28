using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ExtensionsInto
{
    public class Program
    {
        static void Main(string[] args)
        {
            OldClass Obj=new OldClass();
            Obj.Method1();
            Obj.Method2();
            Obj.Method3();

            Obj.Method4(4);
            Obj.Method5(5);
            Obj.Method6(6);

            Console.ReadKey();



        }
    }
}
