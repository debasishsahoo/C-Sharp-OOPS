using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PartialInto
{
     class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 155;
            employee.Firstname = "Debasish";
            employee.LastName = "Sahoo";
            employee.Salary = 8000000000000000000000.000;

            employee.DisplayName();
            employee.DisplayInfo();

            Console.ReadKey();

        }
    }
}
