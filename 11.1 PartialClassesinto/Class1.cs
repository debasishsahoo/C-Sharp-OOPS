using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_PartialClassesinto
{
    public partial class PartialEmp
    {
        public void ChangeId()
        {
            Console.WriteLine("New Id:");
            Console.WriteLine(@"ID is {0}",_id+102);

        }

    }
}
