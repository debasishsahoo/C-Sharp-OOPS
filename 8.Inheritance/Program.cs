using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Inheritance
{
    //Single Inheritance       base class ->derived class

    //Multilevel Inheritance   base class -> derived class -> derived class

    //Multiple Inheritance     (baseclass1 baseclass2) -> derived class

    //Hiearchical Inheritance  (baseclass) -> (derived1 class,derived2 class)

    //Hybrid Inheritance

    #region Rules
    //Rule 1:In Inheritance the constracor of the parent class must be accessible to its child class,else the Inheritance will not possible. because when we create the child class object first it goes and call the parent class constractor so that the parent class variable will be init and can comsume them under the child class.

    //Rule 2:In Inheritance the child class consume the parent class members but the parent class not do so.

    //Rule 3:class can be assigned to a variable of the same class to make it as a reference,ii can also be assigned a varible of its parant to make it as a reference so that the reference startconsuming memory of the object assigned ti it,but alsousing that we control access child class pure memeber
  //a Parent class object can never be assigned to a child class variable.
    #endregion


    class Branch {
        int BranchCode;
        string BranchName, BranchAddress;
        public void GetBranchData()
        {
            Console.WriteLine("ENTER BRANCH DETAILS:");
            Console.WriteLine("ENTER BRANCH CODE");
            BranchCode = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER BRANCH NAME");
            BranchName = Console.ReadLine();
            Console.WriteLine("ENTER BRANCH ADDRESS");
            BranchAddress = Console.ReadLine();
        }
        public void DisplayBranchData()
        {
            Console.WriteLine("BRANCH CODE IS : " + BranchCode);
            Console.WriteLine("BRANCH NAME IS : " + BranchName);
            Console.WriteLine("BRANCH ADDRESS IS : " + BranchAddress);
        }
    }
    class Employee:Branch {
        int EmployeeId, EmployeeAge;
        string EmployeeName, EmployeeAddress;
        public void GetEmployeeData()
        {
            Console.WriteLine("ENTER EMPLYEE DETAILS:");
            Console.WriteLine("ENTER EMPLOYEE ID");
            EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE AGE");
            EmployeeAge = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE NAME");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("ENTER EMPLOYEE ADDRESS");
            EmployeeAddress = Console.ReadLine();
        }
        public void DisplayEmployeeData()
        {
            Console.WriteLine("EMPLOYEE ID IS : " + EmployeeId);
            Console.WriteLine("EMPLOYEE NAME IS : " + EmployeeName);
            Console.WriteLine("EMPLOYEE ADDRESS IS : " + EmployeeAddress);
            Console.WriteLine("EMPLOYEE AGE IS : " + EmployeeAge);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            obj1.GetBranchData();
            obj1.GetEmployeeData();
            obj1.DisplayBranchData();
            obj1.DisplayEmployeeData();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }










}
