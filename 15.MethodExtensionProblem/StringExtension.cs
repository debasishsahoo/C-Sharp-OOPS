using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.MethodExtensionProblem
{
    public static class StringExtension
    {
        public static int GetWordCount(this string inputsting)
        {
            if(!string.IsNullOrEmpty(inputsting))
            {
                string[] words = inputsting.Split(' ');
                return words.Count();
            }
            else
            {
                return 0;
            }
        }

    }
}
