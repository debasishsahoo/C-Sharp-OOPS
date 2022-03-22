using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.AbstractionDetails
{

    //Rule 1
    //"must declare a body because it is not marked abstract,extern,or pertial"

    //public class Ex
    //{
    //    void Abc();
    //}

    //Rule 2
    //Ex.Abc()' is abstract but it is contained in non-abstract type 'Ex
    // public class Ex
    //{
    //    public abstract void Abc();
    //}

    //Rule 3
    //Cannot create an instance of the abstract type or interface 'Ex'
    //public abstract class Ex
    //{
    //    public abstract void Abc();

    //    public static void Main() {
    //        Console.WriteLine("its Works");
    //        Ex e=new Ex();
    //        Console.ReadKey();
    //    }
    //}

    //Rule 4
    public abstract class Ex
    {
        public abstract void Abc1();
        public abstract void Abc2();

    }
    public abstract class Sample : Ex
    {
        public override void Abc1()
        {
            Console.WriteLine("Abc1 Method");
        }

    }















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


}
