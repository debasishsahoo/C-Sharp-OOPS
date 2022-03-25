using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_PartialClassesinto
{
     partial class PartialEmp
    {
        //static int DA = 4500;
        //static int TA = 1000;
        //static int HRA = 7000;
        //public int TotalSAL = DA + TA + HRA;
         partial void DisplayTotalSalary()
        {
            Console.WriteLine("Salary Details:");
            Console.WriteLine(@"Salary is {0}",_salary);

        }


    }
}
