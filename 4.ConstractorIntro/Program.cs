using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ConstractorIntro
{
    //type of Constructors
    //Default Constructors
    //Parameterize Constructors
    //Copy Constructors
    //Static Constructors
    //Private Constructors


    #region Default Constractor
    //public class Student
    //{
    //    static void Main(string[] args)
    //    {
    //        Student S1 = new Student();
    //        Student S2 = new Student();
    //        Console.ReadKey();
    //    }
    //    public Student()
    //    {
    //        Console.WriteLine(" Default Constructor Invoked");
    //    }
    //}
    #endregion

    #region Parameterize Constractor 
    //public class Student
    //{
    //    public int Id;
    //    public string Name;
    //    public string Dept;
    //    public Student(int i, string n, string d)
    //    {
    //        Id = i;
    //        Name = n;
    //        Dept = d;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine(Id + " " + Name + "" + Dept);
    //    }
    //    ~Student()
    //    {
    //        Console.WriteLine("Destructor Invoked");
    //        Console.ReadKey();

    //    }
    //}
    //class TestStudent
    //{
    //    static void Main(string[] args)
    //    {
    //        Student S1 = new Student(1, "Debasish Sahoo", "Dev");
    //        Student S2 = new Student(2, "KD", "Tesing");
    //        S1.Display();
    //        S2.Display();
    //    }
    //}
    #endregion

    #region Copy Constractor 
    //class Student
    //{
    //    int id;
    //    string name;
    //    public Student()
    //    {
    //        Console.WriteLine("Enter Student details:");
    //        Console.WriteLine("Enter Student id:");
    //        id = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter Student Name:");
    //        name = Console.ReadLine();
    //    }
    //    public Student(Student StuOBJ)
    //    {
    //        id = StuOBJ.id;
    //        name = StuOBJ.name;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine(id + " " + name);

    //    }
    //}
    //class TestStudent
    //{
    //    public static void Main(string[] args)
    //    {
    //        Student S1 = new Student();
    //        Student S2 = new Student(S1);
    //        S1.Display();
    //        S2.Display();
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Static Constractor 
    //class Student
    //{
    //    int id;
    //    static int Marks;
    //    public Student()
    //    {
    //        id = 100;
    //    }
    //    static Student()
    //    {
    //        Marks = 100;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine("ID:" + id);
    //        id++;
    //        Console.WriteLine("Marks:" + Marks);
    //        Marks++;
    //    }
    //}
    //class TestStudent
    //{
    //    static void Main()
    //    {
    //        Student s1 = new Student();
    //        s1.Display();
    //        s1.Display();
    //        s1.Display();
    //        s1.Display();
    //        Student s2 = new Student();
    //        s2.Display();
    //        s2.Display();
    //        s2.Display();
    //        s2.Display();
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Private Constractor 
    //class Student
    //{
    //    private Student()
    //    {
    //        Console.WriteLine("This is Private Constructor");
    //    }
    //    static void Main()
    //    {
    //        Student s1 = new Student();
    //        Console.WriteLine("Main Method");
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Constructor Overloading
    class Kundan
    {
        int i;
        public Kundan()
        {
            this.i = 10;
        }
        public Kundan(int i)
        {
            this.i = i;
        }
        public Kundan(int x, int y)
        {
            this.i = x + y;
        }
        public void Display()
        {
            Console.WriteLine("this Value of i:{0}", i);
        }
    }
    class TestStudent
    {
        static void Main(string[] args)
        {
            Kundan obj1 = new Kundan();
            Kundan obj2 = new Kundan(1000);
            Kundan obj3 = new Kundan(15, 23);
            obj1.Display();
            obj2.Display();
            obj3.Display();
            Console.ReadKey();
        }
    }
    #endregion

}
