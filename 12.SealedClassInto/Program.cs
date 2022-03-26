using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SealedClassInto
{
    //class Parent
    //{
    //    public virtual void Show() { }
    //}
    //class Child: Parent
    //{
    //    public sealed override void Show() {
    //        Console.WriteLine("Sealed Method");
    //        Console.ReadKey();
    //    }
    //}
    //class GrandChild : Child
    //{
    //    //public override void Show() { }
    //}

    public class Employee
    {
        protected int _id, _age, _salary;
        protected string _name;
        public virtual void GetEmp()
        {
            Console.WriteLine("Enter Employee Details:");
            Console.WriteLine("Enter Id");
            _id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            _name =Console.ReadLine();
            Console.WriteLine("Enter Age");
            _age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            _salary = int.Parse(Console.ReadLine());

        }
        public virtual void DisplayEmp()
        {
            Console.WriteLine("Enter Employee Details:");
            Console.WriteLine("Enter Id:"+ _id);
            Console.WriteLine("Enter Name:"+ _name);
            Console.WriteLine("Enter Age:"+ _age);
            Console.WriteLine("Enter Salary:"+ _salary);

        }
    }
    public sealed class Manager: Employee
    {
        int _bonus, _ca;
        public override void GetEmp()
        {
            Console.WriteLine("Enter Employee Details:");
            Console.WriteLine("Enter Id");
            _id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            _name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            _age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            _salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Bonus");
            _bonus = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CA");
            _ca = int.Parse(Console.ReadLine());

        }
        public override void DisplayEmp()
        {
            Console.WriteLine("Enter Employee Details:");
            Console.WriteLine("Enter Id:" + _id);
            Console.WriteLine("Enter Name:" + _name);
            Console.WriteLine("Enter Age:" + _age);
            Console.WriteLine("Enter Salary:" + _salary);
            Console.WriteLine("Enter Bonus:" + _bonus);
            Console.WriteLine("Enter CA:" + _ca);

        }

    }
    public class CEO: Manager
    {
        double _equity;

    
    
    }

    internal class Program
    {
        static void Main(string[] args)
        { 
            Manager m1=new Manager();
            m1.GetEmp();
            m1.DisplayEmp();
            Console.ReadKey();


        }
    }
}
