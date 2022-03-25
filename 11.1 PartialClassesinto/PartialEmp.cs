using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_PartialClassesinto
{
    public partial class PartialEmp
    {
        private int _id;
        //private string _firstname;
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
    }
}
