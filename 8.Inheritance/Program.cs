using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Inheritance
{
    #region Relationship
    //1.Association
    //2.Aggregation
    //3.Composition
    //4.Dependency
    //5.Inheritance
    #endregion

    //Single Inheritance       base class ->derived class

    //Multilevel Inheritance   base class -> derived class -> derived class

    //Multiple Inheritance     (baseclass1 baseclass2) -> derived class

    //Hiearchical Inheritance  (baseclass) -> (derived1 class,derived2 class)

    //Hybrid Inheritance

    #region Rules
    //Rule 1:In Inheritance the constracor of the parent class must be accessible to its child class,else the Inheritance will not possible. because when we create the child class object first it goes and call the parent class constractor so that the parent class variable will be init and can comsume them under the child class.

    //Rule 2:In Inheritance the child class consume the parent class members but the parent class not do so.

    //Rule 3:class can be assigned to a variable of the same class to make it as a reference,it can also be assigned a varible of its parant to make it as a reference so that the reference start consuming memory of the object assigned it ,but alsousing that we control access child class pure memeber
    //a Parent class object can never be assigned to a child class variable.
    #endregion

    #region Single-level-Inheritance 
    //class Branch
    //{
    //    int BranchCode;
    //    string BranchName, BranchAddress;
    //    protected void GetBranchData()
    //    {
    //        Console.WriteLine("ENTER BRANCH DETAILS:");
    //        Console.WriteLine("ENTER BRANCH CODE");
    //        BranchCode = int.Parse(Console.ReadLine());
    //        Console.WriteLine("ENTER BRANCH NAME");
    //        BranchName = Console.ReadLine();
    //        Console.WriteLine("ENTER BRANCH ADDRESS");
    //        BranchAddress = Console.ReadLine();
    //    }
    //    protected void DisplayBranchData()
    //    {
    //        Console.WriteLine("BRANCH CODE IS : " + BranchCode);
    //        Console.WriteLine("BRANCH NAME IS : " + BranchName);
    //        Console.WriteLine("BRANCH ADDRESS IS : " + BranchAddress);
    //    }
    //}
    //class Employee : Branch
    //{
    //    int EmployeeId, EmployeeAge;
    //    string EmployeeName, EmployeeAddress;
    //    public void GetEmployeeData()
    //    {
    //        base.GetBranchData();
    //        Console.WriteLine("ENTER EMPLYEE DETAILS:");
    //        Console.WriteLine("ENTER EMPLOYEE ID");
    //        EmployeeId = int.Parse(Console.ReadLine());
    //        Console.WriteLine("ENTER EMPLOYEE AGE");
    //        EmployeeAge = int.Parse(Console.ReadLine());
    //        Console.WriteLine("ENTER EMPLOYEE NAME");
    //        EmployeeName = Console.ReadLine();
    //        Console.WriteLine("ENTER EMPLOYEE ADDRESS");
    //        EmployeeAddress = Console.ReadLine();
    //    }
    //    public void DisplayEmployeeData()
    //    {
    //        base.DisplayBranchData();
    //        Console.WriteLine("EMPLOYEE ID IS : " + EmployeeId);
    //        Console.WriteLine("EMPLOYEE NAME IS : " + EmployeeName);
    //        Console.WriteLine("EMPLOYEE ADDRESS IS : " + EmployeeAddress);
    //        Console.WriteLine("EMPLOYEE AGE IS : " + EmployeeAge);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee obj1 = new Employee();
    //        //obj1.GetBranchData();
    //        obj1.GetEmployeeData();
    //        //obj1.DisplayBranchData();
    //        obj1.DisplayEmployeeData();
    //        Console.WriteLine("Press any key to exist.");
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Multilevel and Hiearchical Inheritance 
    //# Student , #Teaching stuff, #Non-Teaching staff 
    //class Person
    //{
    //    int id;
    //    string name;
    //    string address;
    //    string phone;
    //}
    //class Student : Person
    //{
    //    double fees;
    //    double marks;
    //    double grade;
    //    string dept;
    //}
    //class staff : Person
    //{
    //    string designation;
    //    double salary;
    //}
    //class Teacher : staff
    //{
    //    string Qualifictions;
    //    string subject;
    //}
    //class Not_Teacher : staff
    //{
    //    string dept;
    //    Person boss;
    //}
    #endregion

    //TRANSITIVE
    //a=b and b=c then a=c
    //person=staff and  staff =Teacher  person =teacher /teacher=person

    //class A {
    //    public int a;
    //    public A() {
    //        a = 10;
    //        Console.WriteLine("calling from A");
    //    }
    //}
    //class B:A {
    //    public int b;
    //    public B()
    //    {
    //        b = 15;
    //        Console.WriteLine("calling from B");
    //    }
    //}
    //class Test
    //{
    //    public static void Main() {
    //        Console.WriteLine("calling from Before");
    //        B obj = new B();
    //        Console.WriteLine("calling from after");
    //        Console.WriteLine(obj.b);
    //        Console.WriteLine(obj.a);
    //        Console.ReadKey();

    //    }
    //}

    #region HAS-A
    //public class Address {
    //    public string RoadNo,city, state, zipCode;

    //    public Address(string RoadNo, string city, string state, string zipCode) {
    //    this.RoadNo = RoadNo;
    //    this.city = city;
    //    this.state = state;
    //    this.zipCode = zipCode;
    //    }

    //}
    //public class Employee {

    //    public int id;
    //    public string name;
    //    public Address address;// Emp HAS-A Address

    //    public Employee(int id,string name,Address address) {
    //        this.id = id;
    //        this.name = name;
    //        this.address = address;
    //    }
    //    public void Display() {
    //        Console.WriteLine(id+" "+name+" "+ address.RoadNo+" "+address.city+" "+address.state+" "+address.zipCode);
    //    }
    //}
    //public class Program {
    //    public static void Main(string[] args) {
    //        Address a1 = new Address("11","kolkata","wb","704646");
    //        Employee e1 = new Employee(1,"Deb", a1);
    //        e1.Display();
    //        Console.ReadKey();
    //    }


    //}
    #endregion

    #region Interface
    //interface is a Fully un-implemented Class
    //used for declearing a set of operations of an object.
    //it is a pure abstract class which allows to define abstract methods

    //public interface Example
    //{
    //    void Display();//only abstract method
    //}

    //An Inteface can contain
    //1.Abstarct Methods
    //2.Properties
    //3.Indexes
    //4.Events


    //An Inteface cannot contain
    //1.Non-Abstarct Methods
    //2.Data-fields
    //3.Constructors
    //4.Destructors

    //public interface A 
    //{
    //    void method1();
    //    void method2();
    //}
    // interface B: A
    //{
    //    void method3();
    //    void method4();
    //}
    //class MyClass:B
    //{
    //    public void method1()
    //    {
    //        Console.WriteLine("implement method 1");
    //    }
    //    public void method2()
    //    {
    //        Console.WriteLine("implement method 2");
    //    }
    //    public void method3()
    //    {
    //        Console.WriteLine("implement method 3");
    //    }
    //    public void method4()
    //    {
    //        Console.WriteLine("implement method 4");
    //    }
    //    public void method5()
    //    {
    //        Console.WriteLine("implement method 5");
    //    }

    //}
    //class program {
    //    static void Main() {
    //        MyClass obj=new MyClass();
    //        obj.method1();
    //        obj.method2();
    //        obj.method3();
    //        obj.method4();
    //        obj.method5();
    //        Console.ReadKey();
    //    }
    //}

    //Calculate Area of a rectangale and circle using interface

    //public interface Area
    //{
    //    void area(double a,double b);
    //}
    //class Rectangle : Area 
    //{
    //    public void area(double a, double b) 
    //    {
    //        double areaOfRectangle;
    //        areaOfRectangle = a * b;
    //        Console.WriteLine("The area of Rectangle:" + areaOfRectangle);
    //    }
    //}
    //class Circle : Area
    //{
    //    double PI = 3.14;
    //    public void area(double a, double b)
    //    {
    //        double areaOfCircle;
    //        areaOfCircle = PI * a * a;
    //        Console.WriteLine("The area of Circle:" + areaOfCircle);
    //    }
    //}

    //class Program
    //{
    //    static void Main() 
    //    {
    //    Area RectObj = new Rectangle();
    //         RectObj.area(10,15);

    //    Area CirObj = new Circle();
    //         CirObj.area(10, 0);
    //        Console.ReadKey();
    //    }
    //}




    #endregion

    #region Multiple Inheritance 

    //This is ambiguity Problem

    //Class 1{ Test() { }  }
    //Class 2{ Test() { }  }
    //class 3:1,2{ }

    //public interface Base1 {
    //    void Test();
    //    void Show();
    //}
    //public interface Base2 {
    //    void Test();
    //    void Show();
    //}
    //class MyClass : Base1, Base2 
    //{
    //    public void Test() {
    //        Console.WriteLine("Test is Implemented");
    //    }
    //    public void Show() {
    //        Console.WriteLine("Show is Implemented");
    //    }
    //}
    //class Program {
    //    static void Main(string[] args) {

    //        MyClass obj1 = new MyClass();
    //        obj1.Test();
    //        obj1.Show();

    //        MyClass obj2 = new MyClass();
    //        obj2.Test();
    //        obj2.Show();

    //        MyClass obj3 = new MyClass();
    //        obj3.Test();
    //        obj3.Show();
    //        Console.ReadKey();
    //    }


    //}


    #endregion

    #region Explicit Inteface Implementations

    public interface IBase1
    {
        void Test();
        void Show();
    }
    public interface IBase2
    {
        void Test();
        void Show();
    }
    class MyClass : IBase1, IBase2
    {
         void IBase1.Test()
        {
            Console.WriteLine("Base1 Test is Implemented");
        }
         void IBase1.Show()
        {
            Console.WriteLine("Base1 Show is Implemented");
        }
        void IBase2.Test()
        {
            Console.WriteLine("Base2 Test is Implemented");
        }
        void IBase2.Show()
        {
            Console.WriteLine("Base2 Show is Implemented");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            IBase1 obj1 = new MyClass();
            obj1.Test();
            obj1.Show();

            IBase2 obj2 = new MyClass();
            obj2.Test();
            obj2.Show();

            MyClass myClass = new MyClass();

            //myClass.Test();//not possible  X

            //MyClass.Base1.myClass.Test();  X

            ((IBase1)myClass).Test();
            ((IBase1)myClass).Show();

            ((IBase2)myClass).Test();
            ((IBase2)myClass).Show();

            Console.ReadKey();
        }


    }

    #endregion

}
