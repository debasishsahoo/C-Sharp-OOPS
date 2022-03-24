using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Polymorphism
{
    #region What is Polymorphism
    //Technically we can say that when a function shows different behaviors when we passed different types and numbers of input values, then it is called Polymorphism in C#. So behaving in different ways depending on the input received is known as polymorphism i.e. whenever the input changes, automatically the output or the behavior also changes.
    #endregion

    #region Types of Polymorphism
    //Static Polymorphism / Compile-Time Polymorphism / Early Binding
    //Dynamic Polymorphism / Run-Time Polymorphism / Late Binding
    #endregion

    #region Early Binding
    //Method Overloading
    //Operator overloading
    #endregion

    #region Late Binding
    //Method Overriding
    //Method Hiding
    #endregion

    #region Compile-Time Polymorphism
    //The function call bounded to the class at the time of compilation, if the function is going to be executed from the same bounded class at run-time, then it is called Compile-Time Polymorphism in C#. This happens in the case of Method Overloading because, in case of overloading each method will have a different signature, and based on the method call, we can easily recognize the method which matches the method signature.

    //It is also called Static Polymorphism or Early Binding as at the Compilation time we will be able to know from which class the method going to be executed.
    #endregion

    #region Runtime Polymorphism 
    //The function call bounded to the class at the time of compilation, if the function is going to be executed from a different class (Parent Class) at run-time rather than the class bounded at compilation-time, then it is called Run-Time Polymorphism.This happens in the case of Method Overriding because, in the case of Overriding, we have multiple methods with the same signature i.e.Parent Class and the Child class having the same method implementation.So, in this case, we will be able to know at runtime from which class the method is going to be executed.

    //It is also called Dynamic Polymorphism or Late Binding as at Run-time we will be able to know from which class the method is going to be executed.
    #endregion




    #region What is Method Overloading
    //    If we are defining multiple methods with the same name but with a different signature in a class or in the Parent and Child class, then it is called Method Overloading in C#. That means C#.NET allows us to create a method in the derived class with the same name as the method name defined in the base class.

    //In simple words, we can say that the Method Overloading in C# allows a class to have multiple methods with the same name but with a different signature. The functions or methods can be overloaded based on the number, type (int, float, etc), order, and kind (Value, Ref or Out) of parameters.
    #endregion

    #region Method Overloading
    //class Program
    //{
    //    public void add(int a, int b)
    //    {
    //        Console.WriteLine(a + b);
    //    }
    //    public void add(float x, float y)
    //    {
    //        Console.WriteLine(x + y);
    //    }
    //    public void add(string s1, string s2)
    //    {
    //        Console.WriteLine(s1 + s2);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Program obj = new Program();
    //        obj.add(10, 20);
    //        obj.add(10.5f, 20.5f);
    //        obj.add("Debasish", "Sahoo");
    //        Console.WriteLine("Press any key to exist.");
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Inheritance-Based Overloading
    //class ADD1
    //{
    //    public void add(int a, int b)
    //    {
    //        Console.WriteLine(a + b);
    //    }
    //    public void add(float x, float y)
    //    {
    //        Console.WriteLine(x + y);
    //    }
    //}
    //class ADD2 : ADD1
    //{
    //    public void add(string s1, string s2)
    //    {
    //        Console.WriteLine(s1 + s2);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ADD2 obj = new ADD2();
    //        obj.add(10, 20);
    //        obj.add(10.5f, 20.5f);
    //        obj.add("Debasish", "Sahoo");
    //        Console.WriteLine("Press any key to exist.");
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Constructor Overloading
    //class ConstructorOverloading
    //{
    //    int x, y, z;
    //    public ConstructorOverloading(int x)
    //    {
    //        this.x = x;
    //        Console.WriteLine("First:" + x);
    //    }
    //    public ConstructorOverloading(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //        Console.WriteLine("Second:" + x);
    //    }
    //    public ConstructorOverloading(int x, int y, int z)
    //    {
    //        this.x = x;
    //        this.y = y;
    //        this.z = z;
    //        Console.WriteLine("Third:" + x);
    //    }
    //}
    //class Test
    //{
    //    static void Main(string[] args)
    //    {
    //        ConstructorOverloading obj1 = new ConstructorOverloading(10);
    //        ConstructorOverloading obj2 = new ConstructorOverloading(100, 20);
    //        ConstructorOverloading obj3 = new ConstructorOverloading(1000, 20, 30);
    //        Console.ReadKey();
    //    }
    //}

    #endregion



    #region What is Operator overloading
    //    A user-defined type can overload a predefined C# operator. That is, a type can provide the custom implementation of an operation in case one or both of the operands are of that type. The Overloadable operators section shows which C# operators can be overloaded.

    //Use the operator keyword to declare an operator. An operator declaration must satisfy the following rules:

    //It includes both a public and a static modifier.
    //A unary operator has one input parameter.A binary operator has two input parameters. In each case, at least one parameter must have type T or T? where T is the type that contains the operator declaration.

    //for more:https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading

    #endregion

    #region Different Operators.
    //Operators                                                            Overloadability
    //+x, -x, !x, ~x, ++, --, true, false                                         Y

    //x + y, x - y, x * y, x / y, x % y, x & y, x | y,                            Y
    //x ^ y, x << y, x >> y, x == y, x != y,
    //x < y, x > y, x <= y, x >= y

    //x && y, x || y                                                              Y

    //a[i], a?[i]                                                                 Y

    //(T)x                                                                        Y

    //+=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=                                    Y

    //^x, x = y, x.y, x?.y, c ? t : f, x ?? y,                                    N
    //x ??= y, x..y, x->y, =>, f(x), as,
    //await, checked, unchecked, default, delegate,
    //is, nameof, new, sizeof, stackalloc, switch, typeof, with

    #endregion

    #region Operator Overloading
    //class Box
    //{
    //    private double length;   // Length of a box
    //    private double breadth;  // Breadth of a box
    //    private double height;   // Height of a box

    //    public double getVolume()
    //    {
    //        return length * breadth * height;
    //    }
    //    public void setLength(double len)
    //    {
    //        length = len;
    //    }
    //    public void setBreadth(double bre)
    //    {
    //        breadth = bre;
    //    }
    //    public void setHeight(double hei)
    //    {
    //        height = hei;
    //    }

    //    // Overload + operator to add two Box objects.
    //    public static Box operator +(Box b, Box c)
    //    {
    //        Box box = new Box();
    //        box.length = b.length + c.length;
    //        box.breadth = b.breadth + c.breadth;
    //        box.height = b.height + c.height;
    //        return box;
    //    }

    //    public static bool operator ==(Box lhs, Box rhs)
    //    {
    //        bool status = false;
    //        if (lhs.length == rhs.length && lhs.height == rhs.height
    //           && lhs.breadth == rhs.breadth)
    //        {

    //            status = true;
    //        }
    //        return status;
    //    }
    //    public static bool operator !=(Box lhs, Box rhs)
    //    {
    //        bool status = false;

    //        if (lhs.length != rhs.length || lhs.height != rhs.height ||
    //           lhs.breadth != rhs.breadth)
    //        {

    //            status = true;
    //        }
    //        return status;
    //    }
    //    public static bool operator <(Box lhs, Box rhs)
    //    {
    //        bool status = false;

    //        if (lhs.length < rhs.length && lhs.height < rhs.height
    //           && lhs.breadth < rhs.breadth)
    //        {

    //            status = true;
    //        }
    //        return status;
    //    }
    //    public static bool operator >(Box lhs, Box rhs)
    //    {
    //        bool status = false;

    //        if (lhs.length > rhs.length && lhs.height >
    //           rhs.height && lhs.breadth > rhs.breadth)
    //        {

    //            status = true;
    //        }
    //        return status;
    //    }
    //    public static bool operator <=(Box lhs, Box rhs)
    //    {
    //        bool status = false;

    //        if (lhs.length <= rhs.length && lhs.height
    //           <= rhs.height && lhs.breadth <= rhs.breadth)
    //        {

    //            status = true;
    //        }
    //        return status;
    //    }
    //    public static bool operator >=(Box lhs, Box rhs)
    //    {
    //        bool status = false;

    //        if (lhs.length >= rhs.length && lhs.height
    //           >= rhs.height && lhs.breadth >= rhs.breadth)
    //        {

    //            status = true;
    //        }
    //        return status;
    //    }
    //    public override string ToString()
    //    {
    //        return String.Format("({0}, {1}, {2})", length, breadth, height);
    //    }

    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Box Box1 = new Box();
    //        Box Box2 = new Box();
    //        Box Box3 = new Box();
    //        Box Box4 = new Box();

    //        double volume = 0.0;

    //        // box 1 specification
    //        Box1.setLength(6.0);
    //        Box1.setBreadth(7.0);
    //        Box1.setHeight(5.0);

    //        // box 2 specification
    //        Box2.setLength(12.0);
    //        Box2.setBreadth(13.0);
    //        Box2.setHeight(10.0);

    //        //displaying the Boxes using the overloaded ToString():
    //        Console.WriteLine("Box 1: {0}", Box1.ToString());
    //        Console.WriteLine("Box 2: {0}", Box2.ToString());

    //        // volume of box 1
    //        volume = Box1.getVolume();
    //        Console.WriteLine("Volume of Box1 : {0}", volume);

    //        // volume of box 2
    //        volume = Box2.getVolume();
    //        Console.WriteLine("Volume of Box2 : {0}", volume);

    //        // Add two object as follows:
    //        Box3 = Box1 + Box2;
    //        Console.WriteLine("Box 3: {0}", Box3.ToString());

    //        // volume of box 3
    //        volume = Box3.getVolume();
    //        Console.WriteLine("Volume of Box3 : {0}", volume);

    //        //comparing the boxes
    //        if (Box1 > Box2)
    //            Console.WriteLine("Box1 is greater than Box2");
    //        else
    //            Console.WriteLine("Box1 is not greater than Box2");

    //        if (Box1 < Box2)
    //            Console.WriteLine("Box1 is less than Box2");
    //        else
    //            Console.WriteLine("Box1 is not less than Box2");

    //        if (Box1 >= Box2)
    //            Console.WriteLine("Box1 is greater or equal to Box2");
    //        else
    //            Console.WriteLine("Box1 is not greater or equal to Box2");

    //        if (Box1 <= Box2)
    //            Console.WriteLine("Box1 is less or equal to Box2");
    //        else
    //            Console.WriteLine("Box1 is not less or equal to Box2");

    //        if (Box1 != Box2)
    //            Console.WriteLine("Box1 is not equal to Box2");
    //        else
    //            Console.WriteLine("Box1 is not greater or equal to Box2");

    //        Box4 = Box3;

    //        if (Box3 == Box4)
    //            Console.WriteLine("Box3 is equal to Box4");
    //        else
    //            Console.WriteLine("Box3 is not equal to Box4");

    //        Console.ReadKey();




    //    }
    //}
    #endregion



    #region What is Method Overriding
    //    The process of re-implementing the superclass non-static and non-private method in the subclass with the same signature is called Function Overriding or Method Overriding in C#. The same signature means the name and the parameters should be the same. The implementation of the subclass overrides (i.e. replaces) the implementation of the superclass method.

    //The point that you need to keep in mind is that the overriding method is always going to be executed from the current class object. The superclass method is called the overridden method and the sub-class method is called the overriding method.
    #endregion

    #region Method Overriding
    //class Parent
    //{
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("Super class show method");
    //    }
    //}
    //class Child : Parent
    //{
    //    public override void Show()//<----------is looking for Compile time
    //    {
    //        Console.WriteLine("Sub class override show method");  //<-----------is looking for run time
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Child obj = new Child();
    //        obj.Show();
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Parent class Reference Variable holding subclass object reference
    //class Parent
    //{
    //    public virtual void Show()//<---------Compile time 
    //    {
    //        Console.WriteLine("Super class show method");
    //    }
    //}
    //class Child : Parent
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("Sub class override show method");//<------------Run Time 
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Parent obj = new Child();
    //        obj.Show();
    //        Console.ReadKey();
    //    }
    //}

    #endregion

    #region Using the base keyword to call the parent class methods
    //class Parent
    //{
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("Super class show method");
    //    }
    //}
    //class Child : Parent
    //{
    //    public override void Show()
    //    {
    //        base.Show();
    //        Console.WriteLine("Sub class override show method");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Child obj = new Child();
    //        obj.Show();
    //        Console.ReadKey();
    //    }
    //}

    #endregion



    #region What is Method Hiding
    // When we use the new keyword to hide a base class member, then it is called Method Hiding in C#. We will get a compiler warning if we miss the new keyword. This is also used for re-implementing a parent class method under child class. Re-implementing parent class methods under child classes can be done using two different approaches, such as

    //Method Overriding
    //Method Hiding

    //In the first case, we re-implement the parent class methods under child classes with the permission of parent class because here in parent class the method is declared as virtual giving permission to the child classes for overriding the methods using the override modifier.

    //In the 2nd approach, we re-implement the method of parent class even if those methods are not declared as virtual that is without parent permission we are re-implementing the methods
    #endregion

    #region Method Hiding
    //class Parent
    //{
    //    public void display()
    //    {
    //        Console.WriteLine("Super class display method");
    //    }
    //}
    //class Child : Parent
    //{
    //    public new void display()//<-------compile time 
    //    {

    //        base.display();
    //        Console.WriteLine("Sub class display method");//<-----run time
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Child obj = new Child();
    //        obj.display();
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Parent class Reference Variable holding subclass object reference
    //class Parent
    //{
    //    public void Show()
    //    {
    //        Console.WriteLine("Super class show method");
    //    }
    //}
    //class Child : Parent
    //{
    //    public new void Show()
    //    {
    //        base.Show();
    //        Console.WriteLine("Sub class override show method");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Parent obj = new Child();
    //        obj.Show();
    //        Console.ReadKey();
    //    }
    //}

    #endregion

    #region Using the base keyword to call the parent class methods
    class Parent
    {
        public void Show()
        {
            Console.WriteLine("Super class show method");
        }
    }
    class Child : Parent
    {
        public new void Show()
        {
            base.Show();
            Console.WriteLine("Sub class override show method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.Show();
            Console.ReadKey();
        }
    }

    #endregion


}
