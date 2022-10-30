using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseUC1
{
    public class Progarm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Max Number");
            int output = Generics.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
        }
    }
}