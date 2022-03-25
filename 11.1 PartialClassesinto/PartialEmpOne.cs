using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_PartialClassesinto
{
    public partial class PartialEmp
    {
        private string _firstname;
        public void DisplayName()
        {
            Console.WriteLine(@"Full Name is {0} {1}", _firstname, _lastname);
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine(@"ID is {0}", _id);
            Console.WriteLine(@"First Name is {0}", _firstname);
            Console.WriteLine(@"Last Name is {0}", _lastname);
            Console.WriteLine(@"Salary is {0}", _salary);

        }

         partial void DisplayTotalSalary();
    }
}
