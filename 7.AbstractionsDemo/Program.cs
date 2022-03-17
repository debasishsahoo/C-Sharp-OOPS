using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AbstractionsDemo
{
    public class Laptop
    {
        private string _name = "HP";
        private string _model = "i7";
        private int _count = 2+2+8+6+7+91-40;
        private void Price() {
            Console.WriteLine("Price:$1000");
        }

        public string Name {
        set { _name = value; }
        get { return _name; }
        }
        public string Model {
            set { _model = value; }
            get { return _model; }

        }

        public int Count
        {
            set { _count = value; }
            get { return _count; }

        }

        public void Color() {
            Console.WriteLine("Color:BLACK");
        }
        public void Ram() {
            Console.WriteLine("RAM:16GB");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();

            string LaptopName=laptop.Name;
            string LaptopModel = laptop.Model;
            int LaptopCount = laptop.Count;

            laptop.Color();
            laptop.Ram();

            //laptop._name;
            //laptop.Price();


        }
    }
}
