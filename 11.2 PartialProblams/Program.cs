using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2_PartialProblams
{
    //public class Employee { }
    //public class Customer { }
    //public partial class PartialEmployee : Employee { }
    //public partial class PartialCustomer : Customer { }


    public interface IEmployee { void EmployeeMethod(); }
    public interface ICustomer { void CustomerMethod(); }
    public partial class PartialEmployee : IEmployee , ICustomer
    { 
        public void EmployeeMethod() { }
        public void CustomerMethod() { }

    }
    public partial class PartialCustomer : ICustomer 
    { public void CustomerMethod() { } }












    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
