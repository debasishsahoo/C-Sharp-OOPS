using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ExtensionsInto
{
    public class OldClass
    {
        public int x = 100;
        public void Method1()
        { Console.WriteLine("Method One:"+this.x); }
        public void Method2()
        { Console.WriteLine("Method Two:" + this.x); }
        public void Method3()
        { Console.WriteLine("Method Three:" + this.x); }
    }
}
