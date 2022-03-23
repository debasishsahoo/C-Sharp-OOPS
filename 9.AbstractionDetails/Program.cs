using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.AbstractionDetails
{

    #region Abstract Class
    //A class that is declared by using the keyword abstract is called an abstract class. An abstract class is a partially implemented class used for implementing some of the operations of an object which are common for all next-level subclasses and the remaining abstract methods to be implemented by the next-level subclasses.So it contains both abstract methods and concrete methods including variables, properties, and indexers.

    //It is always created as a superclass next to the interface in the object inheritance hierarchy for implementing common operations from an interface. An abstract class may or may not have abstract methods.But if a class contains an abstract method then it must be declared as abstract.

    //An abstract class cannot be instantiated directly.It’s compulsory to create/derive a subclass from the abstract class in order to provide the functionality to its abstract functions
    #endregion

    #region abstract method
    //A method that does not have a body is called an abstract method.It is declared with the modifier abstract. It contains only a declaration/signature and does not contain the implementation/body/definition of the method.An abstract function should be terminated with a semicolon.Overriding an abstract function is compulsory.
    #endregion

    #region Rules
    //Rule 1:If a method does not have the body, then it should be declared as abstract using the abstract modifier else it leads to a compile-time error: “must declare a body because it is not marked abstract, extern, or partial”

    //public class Ex
    //{
    //    void Abc();
    //}

    //Rule2: If a class has an abstract method it should be declared as abstract by using the keyword abstract else it leads to a compile-time error: ‘Ex.Abc()’ is abstract but it is contained in non-abstract class ‘Ex‘.

    // public class Ex
    //{
    //    public abstract void Abc();
    //}

    //Rule3: If a class is declared as abstract it cannot be instantiated violation leads to compile-time Error: Cannot create an instance of the abstract class or interface ‘Ex’

    //public abstract class Ex
    //{
    //    public abstract void Abc();

    //    public static void Main() {
    //        Console.WriteLine("its Works");
    //        Ex e=new Ex();
    //        Console.ReadKey();
    //    }
    //}

    //Rule4: The sub-classes of an abstract class should override all the abstract methods or it should be declared as abstract else it leads to the compile-time error:
    //public abstract class Ex
    //{
    //    public abstract void Abc1();
    //    public abstract void Abc2();

    //}
    //public abstract class Sample : Ex
    //{
    //    public override void Abc1()
    //    {
    //        Console.WriteLine("Abc1 Method");
    //    }
    //}
    #endregion

    #region Points to Remember 
    //An abstract class can contain both abstract methods and non-abstract (concrete) methods.
    //It can contain both static and instance variables.
    //The abstract class cannot be instantiated but its reference can be created.
    //If any class contains abstract methods then it must be declared by using the keyword abstract.
    //An abstract class can contain sealed methods but an abstract method or class cannot be declared as sealed.
    //A subclass of an abstract class can only be instantiated if it implements all of the abstract methods of its superclass.Such classes are called concrete classes to differentiate them from abstract classes.
    #endregion

    #region Basic Data Abstraction
    //public abstract class MyClass
    //{
    //    public abstract void Calcutale(double x);//common

    //}
    //class Sub1 : MyClass
    //{
    //    public override void Calcutale(double x)
    //    {
    //        Console.WriteLine("Square Root is:" + Math.Sqrt(x));
    //    }
    //}
    //public class Sub2 : MyClass
    //{
    //    public override void Calcutale(double x)
    //    {
    //        Console.WriteLine("Square:" + (x * x));
    //    }
    //}
    //public class Sub3 : MyClass
    //{
    //    public override void Calcutale(double x)
    //    {
    //        Console.WriteLine("Cube:" + (x * x * x));
    //    }
    //}
    //class Test
    //{
    //    static void Main()
    //    {
    //        Sub1 obj1 = new Sub1();
    //        Sub2 obj2 = new Sub2();
    //        Sub3 obj3 = new Sub3();

    //        obj1.Calcutale(4);
    //        obj2.Calcutale(4);
    //        obj3.Calcutale(4);

    //        Console.ReadKey();

    //    }

    //}
    #endregion

    #region Advanced Data Abstraction 1
    //public abstract class Plan
    //{
    //    protected double rate;
    //    public abstract void getRate();
    //    public void calculations(int unit)
    //    {
    //        Console.WriteLine("Bill amount for " + unit + " Unit is");
    //        Console.WriteLine(rate * unit);
    //    }
    //}
    //class CommercialPlan : Plan
    //{
    //    public override void getRate()
    //    {
    //        rate = 7.50;
    //    }
    //}
    //class DomesticPlan : Plan
    //{
    //    public override void getRate()
    //    {
    //        rate = 3.50;
    //    }
    //}
    //class program
    //{
    //    static void Main()
    //    {
    //        Plan P;

    //        Console.WriteLine("Commercial Connection");
    //        P = new CommercialPlan();
    //        P.getRate();
    //        P.calculations(1500);

    //        Console.WriteLine("Domestic Connection");
    //        P = new DomesticPlan();
    //        P.getRate();
    //        P.calculations(500);

    //        P = new CommercialPlan();
    //        P.getRate();
    //        P.calculations(7500);

    //        Console.ReadKey();



    //    }
    //}
    #endregion

    #region Advanced Data Abstraction 2
    abstract class ClSEmployess 
    {
        protected int EmpId, EmpAge;
        protected string EmpName, EmpAddress;
        public abstract void GetEmployeeData();
        public virtual void DisplayEmpData()
        {
            Console.WriteLine("This is Virtual Method");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Employee Id is:"+this.EmpId);
            Console.WriteLine("Employee Name is:"+this.EmpName);
            Console.WriteLine("Employee Address is:"+this.EmpAddress);
            Console.WriteLine("Employee Age is:"+this.EmpAge);
        }
        public ClSEmployess()
        {
            Console.WriteLine("Abstract class Constructor");
        }

    }
    class ClSManager: ClSEmployess
    {
        double Bonus, CA;
        public override void GetEmployeeData() 
        {
            Console.WriteLine("Enter Manager Details:");
            Console.WriteLine("Enter Manager Id:");
            EmpId=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Manager Name:");
            EmpName = Console.ReadLine();

            Console.WriteLine("Enter Manager Address:");
            EmpAddress = Console.ReadLine();

            Console.WriteLine("Enter Manager Age:");
            EmpAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Manager Bonus:");
            Bonus = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Manager CA:");
            CA = double.Parse(Console.ReadLine());


        }
        public override void DisplayEmpData()
        {
            Console.WriteLine("This is Override Method");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Employee Id is:" + this.EmpId);
            Console.WriteLine("Employee Name is:" + this.EmpName);
            Console.WriteLine("Employee Address is:" + this.EmpAddress);
            Console.WriteLine("Employee Age is:" + this.EmpAge);
            Console.WriteLine("Employee Bonus is:" + this.Bonus);
            Console.WriteLine("Employee CA is:" + this.CA);
        }

    }
    class Program
    {
        static void Main()
        {
            ClSManager cm = new ClSManager();
            cm.GetEmployeeData();
            cm.DisplayEmpData();
            Console.ReadKey();
        }
        
    }
    #endregion









}
