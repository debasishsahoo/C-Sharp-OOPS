using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PartialInto
{
    public class Employee
    {
        private int _id;
        private string _firstname;
        private string _lastname;
        private double _salary;

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

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
    }
}
