using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.StaticClassinto
{
    //class College 
    //{
    //    public static string CollegeName;
    //    public static string CollegeAddres;

    //    static College()
    //    {
    //        CollegeName = "ABC";
    //        CollegeAddres = "Kolkata";
    //    }
    //}
    // class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //College c1=new College();



    //        College.CollegeName = "GMIT";

    //        Console.WriteLine(College.CollegeName);
    //        Console.WriteLine(College.CollegeAddres);
    //        Console.ReadKey();
    //    }
    //}

    class Student
    {   // non Static data Member
        public string StudentName;
        public string Course;

        //Non Static Method
        public void SetStudentDetails(string SN,string C)
        {
            StudentName=SN;
            Course=C;
        }
        public void DisplayStudentDetails()
        {
             Console.WriteLine(StudentName+"-"+Course);
        }


        //Static data Member
        public static string CollegeName="ABC";
        public static string CollegeAddres= "Kolkata";
        //Static Method
        public static void CollegeDetails() 
        {
            Console.WriteLine(CollegeName);
            Console.WriteLine(CollegeAddres);

        }

    }

    class Program {

        static void Main() {

            Student.CollegeDetails();

            //Student.DisplayStudentDetails();
            Student student1 = new Student();
            Student student2 = new Student();

            student1.SetStudentDetails("Abir", "Btech");
            student2.SetStudentDetails("Deb", "Btech");

            student1.DisplayStudentDetails();
            student2.DisplayStudentDetails();
            Console.ReadKey();
        }
    }















}
