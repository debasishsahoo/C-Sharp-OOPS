using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ExtensionsInto
{
    public static class NewClass
    {
        public static void Method4(this OldClass O,int x)
        { Console.WriteLine("Method Four:" + x); }

        public static void Method5(this OldClass O, int x)
        { Console.WriteLine("Method Five:" + x); }
        public static void Method6(this OldClass O, int x)
        { Console.WriteLine("Method Six:" + x); }
    }
}
