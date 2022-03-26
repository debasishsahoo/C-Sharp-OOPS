using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.OppIntro
{
    public class Student
    {
        public int id;
        public string name;
        public string Dept;

        public Student() { }
        public void insert(int i, string n, string d)
        {
            id = i;
            name = n;
            Dept = d;
        }
        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + Dept);
            Console.ReadKey();
        }
    }
    class DevStudent
    {
        public static void Main()
        {
            Student S1 = new Student(); //Object
            Student S2 = new Student();
            S1.insert(1, "MIR", "DEV");
            S2.insert(10, "Kundan", "TESING");
            S1.Display();
            S2.Display();

            //different typee of class
            //Abstract Class  done
            //Partial Class   done
            //Concrete Class
            //Sealed Class    done
            //Staic Class



        }

    }

}
