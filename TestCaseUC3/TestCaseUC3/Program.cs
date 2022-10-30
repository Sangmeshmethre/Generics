using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseUC3
{
    public class Progarm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Max Numner");
            string stringoutput = Generics.MaximumStringNumber("22", "33", "444");
            Console.WriteLine(stringoutput);
        }
    }
}