using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB01
{
    public class LibClass01
    {
        internal int id = 999;
        protected internal long SAl = 1500000000000000;
        public string name = "Debasish";
    }
    public class LibClass02
    {
        public void Test()
        {
            LibClass01 instance = new LibClass01();
            Console.WriteLine(instance.id);
        }
    }
}
