using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicaProgarm195RF
{
    public class Progarm
    {
        public static void Main(string[] args)
        {
            //int[] intArray = { 112, 344, 432, 555, 678 };
            GemericMaximum<int> generic = new GemericMaximum<int>(2, 3, 1);
            int result = generic.MaxMethod();
            Console.WriteLine(result);


            //double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GemericMaximum<double> generic1 = new GemericMaximum<double>(21.2, 42.2, 53.2);
            double result1 = generic1.MaxMethod();
            Console.WriteLine(result1);
        }
    }
}