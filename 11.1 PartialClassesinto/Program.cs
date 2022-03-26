using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_PartialClassesinto
{
     class Program
    {
        static void Main(string[] args)
        {
            PartialEmp employee = new PartialEmp();
            employee.Id = 155;
            employee.Firstname = "Debasish";
            employee.LastName = "Sahoo";
            employee.Salary = 80000000;

            employee.DisplayName();
            employee.DisplayInfo();
            //employee.DisplayTotalSalary();
            employee.ChangeId();

            Console.ReadKey();

        }
    }
}
