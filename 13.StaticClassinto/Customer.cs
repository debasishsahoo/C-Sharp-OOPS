using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.StaticClassinto
{
    public class Customer
    {
        public string CustomerCode { get; set; }    
        public string CustomerName { get; set; }

        private string MachinName = "";

        public Customer()
        {

            MachinName= CommonTask.GetComputerName();
        }





        //private bool IsEmpty(string value)
        //{
        //if(value.Length>0)
        //    {
        //        return true;
        //    }
        //return false;
        
        //}

        public void Insert() 
        {

  if (!CommonTask.IsEmpty(CustomerCode) && !CommonTask.IsEmpty(CustomerName)) { }
        }


    }
}
