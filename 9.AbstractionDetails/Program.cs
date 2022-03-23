using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.AbstractionDetails
{

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

    #region Basic Data Abstraction
    //public abstract class MyClass {
    //    public abstract void Calcutale(double x) ;//common

    //}
    //class Sub1:MyClass 
    //{
    //    public override void Calcutale(double x) 
    //    {
    //    Console.WriteLine("Square Root is:"+Math.Sqrt(x));
    //    }
    //}
    //public class Sub2:MyClass 
    //{
    //    public override void Calcutale(double x)
    //    {
    //        Console.WriteLine("Square:" + (x*x));
    //    }
    //}
    //public class Sub3 : MyClass 
    //{
    //    public override void Calcutale(double x)
    //    {
    //        Console.WriteLine("Cube:" + (x * x * x));
    //    }
    //}

    //class Test {

    //static void Main()
    //    {
    //        Sub1 obj1=new Sub1();
    //        Sub2 obj2=new Sub2();
    //        Sub3 obj3=new Sub3();

    //        obj1.Calcutale(4);
    //        obj2.Calcutale(4);
    //        obj3.Calcutale(4);

    //        Console.ReadKey();

    //    }

    //} 
    #endregion


}
