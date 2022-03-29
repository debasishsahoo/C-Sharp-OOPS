using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PropertiesInto
{
    public class Ex
    {
        //Read-Only Property 
        //AccessModifire Datatype PropertyName{get{return Data;}}

        //Write-Only Property 
        //AccessModifire Datatype PropertyName{set{Data=value;}}
        //Read Write Property
        //AccessModifire Datatype PropertyName
        //{
        //get{return Data;}
        //set{Data=value;}
        //}
        private int _empid, _empsal;
        private string _name;

        private int _HRA, _DA, _TA,_TotalSal;


        public int empid
        {
            get { return _empid; }
            set { _empid = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int empsal
        {
            get { return _empsal; }
            set { _empsal = value; }
        }

        public int SetHRA
        { 
            set { _HRA = value; }
        
        }
        public int SetDA
        {
            set { _DA = value; }

        }
        public int SetTA
        {
            set { _TA = value; }

        }
        public int TotalSal
        {
            get { return _TotalSal; }
        }
        public void Sal_Calculations()
        {
            _TotalSal = _empsal + _HRA + _TA + _DA;
        }
    }
    public class AutoEx
    {
        //Auto-implemented Property
        public int A { get; set; }
        public int B { get; set; }
        public int Add()
        {
            return A + B;
        }

    }
    public class Student
    {
        public int id;
        public string name;
        public int PassMark;
    }

    public class EnggStudent
    {
        private int id;
        private string name;
        private int passmark;

        public void SetId(int ID)
        {
            if(ID<0)
            {
                throw new Exception("Id Cant be Zero");
            }
            this.id=ID;
        }
        public int GetId()
        {
            return this.id; 
        }


        public void SetName(string Name)
        {
          if(string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name Should not be Empty");
            }
          this.name=Name;   
        }
        public string GetName() { return name; }

        public void SetPassMark(int PassMark)
        {
            if (PassMark < 0)
            {
                throw new Exception("Marks Cant be Zero");
            }
            this.passmark = PassMark;
        }
        public int GetPassMark() {
            return passmark ;
            ;
        }

    }

    public class ArtStudent
    {

        private int id;
        private string name;
        private int passmark;

        public int Id
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Id Cant be Zero");
                }
                if (value >1000000)
                {
                    throw new Exception("Id Cant be Bigger than 100000");
                }

                this.id = value;

            }
            get { return this.id; }
            
        }
        public string Name
        {

            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name Should not be Empty");
                }
                this.name = Name;
            }
            get 
            {
                return name;
            }
            
            
        }
        public int PassMark
        {
            set {
                if (value < 0)
                {
                    throw new Exception("Marks Cant be Zero");
                }
                this.passmark = value;
            
              }
            get { return passmark; }
            
           
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex ex = new Ex();
            //ex.empid = 101;
            //ex.empsal = 100000;
            //ex.name = "Debasish";
            //ex.SetHRA = 1500;
            //ex.SetDA = 10000;
            //ex.SetTA = 4500;

            //Console.WriteLine("Details:");
            //Console.WriteLine(ex.empid);
            //Console.WriteLine(ex.name);
            //Console.WriteLine(ex.empsal);

            //ex.Sal_Calculations();

            //Console.WriteLine(ex.TotalSal);

            //AutoEx AEX=new AutoEx();
            //AEX.A = 1500;
            //AEX.B = 2500;

            //Console.WriteLine(AEX.Add());

            //            Student student = new Student();

            //            student.id = -100;
            //            student.name = null; 
            //            student.PassMark = 0;

            //Console.WriteLine("ID={0} && Name={1}&&PassMark={2}", student.id, student.name, student.PassMark);




    //        EnggStudent student = new EnggStudent();

    //        student.SetId(100);
    //        student.SetName("a");
    //        student.SetPassMark(-5);

    //Console.WriteLine("ID={0} && Name={1}&&PassMark={2}", student.GetId(), student.GetName(), student.GetPassMark());

            ArtStudent artStudent = new ArtStudent();

            artStudent.Id = 100;
            artStudent.Name = "dEBASISH";
            artStudent.PassMark=10;


















            Console.ReadKey();










        }
    }
}
