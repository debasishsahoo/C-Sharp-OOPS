using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.AcessSpecifiers
{
    //Acess Specifiers
    // Private ------------------limtes to Containing class only
    // Public  ------------------No Limites
    // Proteced------------------limtes to Containing class and Derived Class
    // Internal------------------only Current Assembly & same File
    // Proteced Internal---------Current Assembly or types derived from the contaning class

    #region Private 1
    //public class Student
    //{   //Private Variable
    //    private int _id;
    //    private string _name;
    //    private string _email;

    //    //Private Methods
    //    private string GetDetails() {
    //        return this._id + "" + this._name + "" + this._email;
    //    }

    //}
    //public class SchoolStudent
    //{
    //    public static void Main()
    //    {
    //        Student schoolStudent = new Student();
    //        Console.WriteLine(schoolStudent._id);
    //        Console.WriteLine(schoolStudent._name);
    //        Console.WriteLine(schoolStudent._email);
    //        Console.WriteLine(schoolStudent.GetDetails());
    //    }
    //}
    #endregion

    #region Private 2
    //public class Student
    //{   //Private Variable
    //    private int _id;
    //    private string _name;
    //    private string _email;

    //    //Private Methods
    //    private string GetDetails()
    //    {
    //        return this._id + "" + this._name + "" + this._email;
    //    }
    //    public class SchoolStudent
    //    {
    //        public static void Main()
    //        {
    //            Student schoolStudent = new Student();
    //            schoolStudent._id = 100;
    //            schoolStudent._name = "Debasish";
    //            schoolStudent._email = "a@a.com";

    //            Console.WriteLine(schoolStudent._id);
    //            Console.WriteLine(schoolStudent._name);
    //            Console.WriteLine(schoolStudent._email);
    //            Console.WriteLine(schoolStudent.GetDetails());
    //            Console.ReadKey();
    //        }
    //    }


    //}

    #endregion

    #region Public
    //public class Student
    //{   //Public Variable
    //    public int _id;
    //    public string _name;
    //    public string _email;

    //    //Public Methods
    //    public string GetDetails()
    //    {
    //        return this._id + "" + this._name + "" + this._email;
    //    }

    //}
    //public class SchoolStudent
    //{
    //    public static void Main()
    //    {
    //        Student schoolStudent = new Student();
    //        schoolStudent._id = 100;
    //        schoolStudent._name = "Debasish";
    //        schoolStudent._email = "a@a.com";

    //        Console.WriteLine(schoolStudent._id);
    //        Console.WriteLine(schoolStudent._name);
    //        Console.WriteLine(schoolStudent._email);
    //        Console.WriteLine(schoolStudent.GetDetails());
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Protected 1
    //public class Student
    //{   //Private Variable
    //    protected int _id;
    //    protected string _name;
    //    protected string _email;

    //    //Private Methods
    //    protected string GetDetails()
    //    {
    //        return this._id + "" + this._name + "" + this._email;
    //    }

    //}
    //public class SchoolStudent: Student
    //{
    //    public static void Main()
    //    {
    //        SchoolStudent schoolStudent = new SchoolStudent();
    //            schoolStudent._id = 100;
    //            schoolStudent._name = "Debasish";
    //            schoolStudent._email = "a@a.com";

    //        Console.WriteLine(schoolStudent._id);
    //        Console.WriteLine(schoolStudent._name);
    //        Console.WriteLine(schoolStudent._email);
    //        Console.WriteLine(schoolStudent.GetDetails());
    //    }
    //}
    #endregion

    #region Protected 2
    //public class Student
    //{   //Private Variable
    //    protected int _id;
    //    protected string _name;
    //    protected string _email;

    //    //Private Methods
    //    protected string GetDetails()
    //    {
    //        return this._id + "" + this._name + "" + this._email;
    //    }
    //    public static void Main()
    //    {
    //        Student schoolStudent = new Student();
    //            schoolStudent._id = 100;
    //            schoolStudent._name = "Debasish";
    //            schoolStudent._email = "a@a.com";
    //        Console.WriteLine(schoolStudent._id);
    //        Console.WriteLine(schoolStudent._name);
    //        Console.WriteLine(schoolStudent._email);
    //        Console.WriteLine(schoolStudent.GetDetails());
    //    }

    //}
    #endregion

    #region Internal
    //public class Student
    //{   //Private Variable
    //    internal int _id;
    //    internal string _name;
    //    internal string _email;

    //    //Private Methods
    //    internal string GetDetails()
    //    {
    //        return this._id + "" + this._name + "" + this._email;
    //    }

    //}
    //public class SchoolStudent
    //{
    //    public static void Main()
    //    {
    //        Student schoolStudent = new Student();
    //        schoolStudent._id = 100;
    //        schoolStudent._name = "Debasish";
    //        schoolStudent._email = "a@a.com";
    //        Console.WriteLine(schoolStudent._id);
    //        Console.WriteLine(schoolStudent._name);
    //        Console.WriteLine(schoolStudent._email);
    //        Console.WriteLine(schoolStudent.GetDetails());
    //    }
    //}
    #endregion

    #region Proteced Internal
    public class Student
    {   //Private Variable
        protected internal int _id;
        protected internal string _name;
        protected internal string _email;

        //Private Methods
        protected string GetDetails()
        {
            return this._id + "" + this._name + "" + this._email;
        }

    }
    public class SchoolStudent
    {
        public static void Main()
        {
            SchoolStudent schoolStudent = new SchoolStudent();
            //schoolStudent._id = 100;
            //schoolStudent._name = "Debasish";
            //schoolStudent._email = "a@a.com";

            //Console.WriteLine(schoolStudent._id);
            //Console.WriteLine(schoolStudent._name);
            //Console.WriteLine(schoolStudent._email);
            //Console.WriteLine(schoolStudent.GetDetails());
        }
    }
    #endregion





}
