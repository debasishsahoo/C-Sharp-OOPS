using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB01;

namespace LIB02
{
    public class LibClass03 : LibClass01
    {
        public void Test()
        {
            LibClass01 instance = new LibClass01();
            //Console.WriteLine(instance.id);
            Console.WriteLine(base.SAl);
            Console.WriteLine(instance.name);
        }
    }
}
