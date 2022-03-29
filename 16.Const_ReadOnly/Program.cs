using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Const_ReadOnly
{
    //class ConstExample
    //{
    //    public static int Number1 = 15;
    //    public const int Number2 = 10;
    //}

    //class ReadOnlyExample
    //{
    //    public readonly int Number3 = 150;

    //}
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ConstExample.Number1 = 10;
    //        Console.WriteLine(ConstExample.Number1);

    //        //ConstExample.Number2 = 10;
    //        //Console.WriteLine(ConstExample.Number2);



    //        Console.ReadKey();
    //    }
    //}

    class ReadOnlyExample
    {
        public readonly int number = 5;
        public ReadOnlyExample()
        {
            number = 20;
        }
        public ReadOnlyExample(bool IsAnotherInstance)
        {
            number = 100;
        }
    }
    class Program
    {

        int x;// Non-Static Variable
        static int y = 200; //Static Variable
        const float PI = 3.14f; //Const Variable
        readonly bool flag;//Readonly Variable

        public Program(int x,bool flag)
        {
            this.x = x;
            this.flag = flag;
        }

        static void Main()
        {
            ReadOnlyExample readonlyInstance= new ReadOnlyExample();
            Console.WriteLine(readonlyInstance.number);

            ReadOnlyExample readonlyAnotherInstance = new ReadOnlyExample(true);
            Console.WriteLine(readonlyAnotherInstance.number);




            Console.WriteLine(Program.y);//200
            Console.WriteLine(Program.PI);//3.14

            Program OBJ1 = new Program(50,true);
            Program OBJ2 = new Program(100,false);

            Console.WriteLine(OBJ1.x+" "+ OBJ1.x);//50 50
            Console.WriteLine(OBJ2.flag + " " + OBJ2.flag); //true true

            Console.ReadKey();
        }
    }



}
