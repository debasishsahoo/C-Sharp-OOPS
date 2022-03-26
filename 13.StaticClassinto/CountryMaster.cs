using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.StaticClassinto
{
    public class CountryMaster
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        private string ComputerName 
        { 
            get
            {
                return System.Environment.MachineName;
            
            } 
        
        }

        public void Insert() { }

    }
}
