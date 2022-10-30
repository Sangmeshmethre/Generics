using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseUC2
{
    public class Progarm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Max Number");
            double output = Generics.MaximumFloatNumber(111.2, 22.0, 33.23);
            Console.WriteLine(output);
        }
    }
}